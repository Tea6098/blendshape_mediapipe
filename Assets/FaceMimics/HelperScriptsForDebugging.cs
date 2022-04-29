using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;



public static class HelperScriptsForDebugging
{


   public static List<Vector3> LoadVector3FromCSV(string filepath)
  {
    var s = System.IO.File.ReadAllLines(filepath);
    var l = new List<Vector3>();
    foreach (var line in s)
    {
      var p = line.Split(',');
      var v = new Vector3(float.Parse(p[0]), float.Parse(p[1]), float.Parse(p[2]));
      l.Add(v);
    }

    return l;



  }
    public static bool SaveVector3ToCSV(Vector3[] l, string filepath)
    {

        string sb = "";
        for (int index = 0; index < l.Length; index++)
        {
            sb += l[index].x + "," + l[index].y + "," + l[index].z + ",\n";

        }

      sb =sb.Remove(sb.Length - 1);


        System.IO.File.WriteAllText(filepath, sb);

        return true;
    }


    public static bool ByteArrayToFile(string path, byte[] byteArray)
    {
        try
        {
            using (System.IO.FileStream fs = System.IO.File.Create(path))
            {
           
                fs.Write(byteArray, 0, byteArray.Length);
                return true;
            }
        }
        catch (System.Exception ex)
        {
            Debug.Log("Exception caught in process: "+ ex.Message);
            return false;
        }
    }

    public static bool StringToFile(string path, string str)
    {
        try
        {
            System.IO.File.WriteAllText(path, str);
            return true;
        }
        catch (System.Exception ex)
        {
            Debug.Log("Exception caught in process: " + ex.Message);
            return false;
        }
    }



    public static void SaveTextureAsPNG(Texture2D _texture, string _fullPath)
    {
        byte[] _bytes = _texture.EncodeToPNG();
        System.IO.File.WriteAllBytes(_fullPath, _bytes);
        Debug.Log(_bytes.Length / 1024 + "Kb was saved as: " + _fullPath);
    }

    public static void SaveTextureAsPNG(RenderTexture rtexture, string _fullPath)
    {
        RenderTexture prevactive = RenderTexture.active;
        RenderTexture.active = rtexture;
        var texture = new Texture2D(rtexture.width, rtexture.height, TextureFormat.RGBA32,false); 
        texture.ReadPixels(new Rect(0, 0, rtexture.width, rtexture.height), 0, 0);
        texture.Apply();
        RenderTexture.active = prevactive;

        
        byte[] _bytes = texture.EncodeToPNG();

  

        System.IO.File.WriteAllBytes(_fullPath, _bytes);
       
        Debug.Log(_bytes.Length / 1024 + "Kb was saved as: " + _fullPath);
    }

 

    public  static byte[] Color32ArrayToByteArray(Color32[] colors)
    {
        if (colors == null || colors.Length == 0)
            return null;

        int lengthOfColor32 = Marshal.SizeOf(typeof(Color32));
        int length = lengthOfColor32 * colors.Length;
        byte[] bytes = new byte[length];

        GCHandle handle = default(GCHandle);
        try
        {
            handle = GCHandle.Alloc(colors, GCHandleType.Pinned);
            System.IntPtr ptr = handle.AddrOfPinnedObject();
            Marshal.Copy(ptr, bytes, 0, length);
        }
        finally
        {
            if (handle != default(GCHandle))
                handle.Free();
        }

        return bytes;
    }




}

/*
public class HelperScriptsForDebugging : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/
