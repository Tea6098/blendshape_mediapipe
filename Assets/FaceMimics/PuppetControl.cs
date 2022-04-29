using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Barracuda;
using System.Runtime.InteropServices;

[RequireComponent(typeof(SkinnedMeshRenderer))]
public class PuppetControl : MonoBehaviour
{

  [SerializeField] private  Mediapipe.Unity.FaceMesh.FaceMeshGraph _graph;
  [SerializeField] Vector3 _headX;
  [SerializeField] Vector3 _headY;
  [SerializeField] Vector3 _headZ;
  [SerializeField] Transform _headBone;
  [SerializeField] Transform _eyeLBone;
  [SerializeField] Transform _eyeRBone;



  [SerializeField] private NNModel _modelSource;
  private IWorker worker;
  private bool _isAvatarUpdated = false;




  OneEuroFilter<Quaternion> _head;
  [SerializeField] float _headBoneFreq;

  private float[] _mouth;

  private int[] _mouthIndices= {10, 11, 12, 13, 14, 15, 16, 17, 20, 21, 22, 54, 62, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 186, 192, 195, 198, 199, 202, 206, 246, 248, 250, 260, 315, 316, 320, 321, 351, 374, 393, 395, 396, 397, 398, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 444, 450, 451, 453, 454, 455, 456, 457, 458, 459, 460, 462, 463, 464, 465, 466, 467};
  List<Vector3> _faceVerts;  //not really local

  public List<Vector3> GetFaceVertsLocal()=> _faceVerts;


  SkinnedMeshRenderer _smr;
  int [] _mouthBlendshapeIndices = {0, 1, 2, 3, 4, 8};
  [SerializeField ] int _multiplier =100;

  // Start is called before the first frame update
  void Start()
  {
    _head = new OneEuroFilter<Quaternion>(_headBoneFreq);
    _smr = GetComponent<SkinnedMeshRenderer>();

    if(_modelSource != null)
    {

      //var grunner = ((Mediapipe.Unity.FaceMesh.FaceMeshSolution)_solution).graphRunner;
     // _graph.OnMultiFaceLandmarksOutput+=DrawLater;

      worker = _modelSource.CreateWorker();
      StartCoroutine(MouthBlendshapes());
    }
  }
  
  // Update is called once per frame
  void Update()
  {
    UpdateFilters();
  }

  private void UpdateFilters()
  {
    _head.UpdateParams(_headBoneFreq);
  }
  public void UpdateHead(RotationVectors v)
  {
    //headZvector
    // var headAngles = headRot.eulerAngles;
    //h
    _headX = v.vX;
    _headY = v.vY;
    _headZ = v.vZ;
    _headBone.rotation = _head.Filter(Quaternion.LookRotation(_headZ,_headY));

  }

  private IEnumerator MouthBlendshapes()
  {
    if (_isAvatarUpdated)
    {
      Debug.Log("mouth");
      _mouth = copyVector3ArrtoFloatArr(_faceVerts, _mouthIndices);
      using (var input = new Tensor(new int[] { 1, _mouthIndices.Length * 3 }, _mouth))
      {
        // execute neural network with specific input and get results back
        var output = worker.Execute(input).PeekOutput();
        // allow main thread to run until neural network execution has finished
        yield return new WaitForCompletion(output);
        for (var n = 0; n < _mouthBlendshapeIndices.Length; n++)
        {
          _smr.SetBlendShapeWeight(_mouthBlendshapeIndices[n], output[n] * _multiplier);
        }
      }
    }
    // wait until a new image is provided
    _isAvatarUpdated = false;

    while (!_isAvatarUpdated) 
    {
      yield return null;
    }

    StartCoroutine(MouthBlendshapes());

  }





  public void UpdateMesh(Mesh m) //this is global coordinates we want model coordinates for blendshapes
  {
    _faceVerts = new List<Vector3>();
    _faceVerts.AddRange(m.vertices);
  }

  /*
  public void DrawLater( List<Mediapipe.NormalizedLandmarkList> target)
  {
   

    if(target!=null)
    if(target.Count>0)
    {
     _faceVerts = new List<Vector3>();
    // var landmark =  target[0].Landmark[0];
      foreach (var l in target[0].Landmark){

          _faceVerts.Add(new Vector3(l.X, l.Y, l.Z));



      }


       // Debug.Log(_faceVerts[0].x +" "+_faceVerts[0].y+" "+_faceVerts[0].z);
      _isAvatarUpdated = true;


    }
   


  }

  */

  float [] copyVector3ArrtoFloatArr(List<Vector3> input, int [] indices=null)
  {
    if (indices==null)
    {
      var result = new float[3*input.Count];
      for (int i = 0; i< input.Count; i+=3)
      {
        result[i]= input[i].x;
        result[i+1]= input[i].y;
        result[i+2]= input[i].z;
      }
      return result;
    }
    else
    {
      var result = new float[3*indices.Length];
      for (int i = 0; i< result.Length; i+=3)
      {
        //if (i ==507) Debug.Log("copying indice " + i.ToString());
        result[i]  = input[indices[i/3]].x;
        result[i+1]= input[indices[i/3]].y;
        result[i+2]= input[indices[i/3]].z;
      }

      return result;


    }
  }
}
