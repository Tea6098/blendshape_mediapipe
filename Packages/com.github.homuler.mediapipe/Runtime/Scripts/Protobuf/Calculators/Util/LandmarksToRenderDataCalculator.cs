// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/calculators/util/landmarks_to_render_data_calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/calculators/util/landmarks_to_render_data_calculator.proto</summary>
  public static partial class LandmarksToRenderDataCalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/calculators/util/landmarks_to_render_data_calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LandmarksToRenderDataCalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRtZWRpYXBpcGUvY2FsY3VsYXRvcnMvdXRpbC9sYW5kbWFya3NfdG9fcmVu",
            "ZGVyX2RhdGFfY2FsY3VsYXRvci5wcm90bxIJbWVkaWFwaXBlGiRtZWRpYXBp",
            "cGUvZnJhbWV3b3JrL2NhbGN1bGF0b3IucHJvdG8aGm1lZGlhcGlwZS91dGls",
            "L2NvbG9yLnByb3RvIu4ECiZMYW5kbWFya3NUb1JlbmRlckRhdGFDYWxjdWxh",
            "dG9yT3B0aW9ucxIcChRsYW5kbWFya19jb25uZWN0aW9ucxgBIAMoBRIoCg5s",
            "YW5kbWFya19jb2xvchgCIAEoCzIQLm1lZGlhcGlwZS5Db2xvchIqChBjb25u",
            "ZWN0aW9uX2NvbG9yGAMgASgLMhAubWVkaWFwaXBlLkNvbG9yEhQKCXRoaWNr",
            "bmVzcxgEIAEoAToBMRImChh2aXN1YWxpemVfbGFuZG1hcmtfZGVwdGgYBSAB",
            "KAg6BHRydWUSIQoSdXRpbGl6ZV92aXNpYmlsaXR5GAYgASgIOgVmYWxzZRIf",
            "ChR2aXNpYmlsaXR5X3RocmVzaG9sZBgHIAEoAToBMBIfChB1dGlsaXplX3By",
            "ZXNlbmNlGAggASgIOgVmYWxzZRIdChJwcmVzZW5jZV90aHJlc2hvbGQYCSAB",
            "KAE6ATASJQoabWluX2RlcHRoX2NpcmNsZV90aGlja25lc3MYCiABKAE6ATAS",
            "JgoabWF4X2RlcHRoX2NpcmNsZV90aGlja25lc3MYCyABKAE6AjE4Ei4KFG1p",
            "bl9kZXB0aF9saW5lX2NvbG9yGAwgASgLMhAubWVkaWFwaXBlLkNvbG9yEi4K",
            "FG1heF9kZXB0aF9saW5lX2NvbG9yGA0gASgLMhAubWVkaWFwaXBlLkNvbG9y",
            "Ml8KA2V4dBIcLm1lZGlhcGlwZS5DYWxjdWxhdG9yT3B0aW9ucxi90p17IAEo",
            "CzIxLm1lZGlhcGlwZS5MYW5kbWFya3NUb1JlbmRlckRhdGFDYWxjdWxhdG9y",
            "T3B0aW9ucw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, global::Mediapipe.ColorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.LandmarksToRenderDataCalculatorOptions), global::Mediapipe.LandmarksToRenderDataCalculatorOptions.Parser, new[]{ "LandmarkConnections", "LandmarkColor", "ConnectionColor", "Thickness", "VisualizeLandmarkDepth", "UtilizeVisibility", "VisibilityThreshold", "UtilizePresence", "PresenceThreshold", "MinDepthCircleThickness", "MaxDepthCircleThickness", "MinDepthLineColor", "MaxDepthLineColor" }, null, null, new pb::Extension[] { global::Mediapipe.LandmarksToRenderDataCalculatorOptions.Extensions.Ext }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LandmarksToRenderDataCalculatorOptions : pb::IMessage<LandmarksToRenderDataCalculatorOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LandmarksToRenderDataCalculatorOptions> _parser = new pb::MessageParser<LandmarksToRenderDataCalculatorOptions>(() => new LandmarksToRenderDataCalculatorOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LandmarksToRenderDataCalculatorOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.LandmarksToRenderDataCalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LandmarksToRenderDataCalculatorOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LandmarksToRenderDataCalculatorOptions(LandmarksToRenderDataCalculatorOptions other) : this() {
      _hasBits0 = other._hasBits0;
      landmarkConnections_ = other.landmarkConnections_.Clone();
      landmarkColor_ = other.landmarkColor_ != null ? other.landmarkColor_.Clone() : null;
      connectionColor_ = other.connectionColor_ != null ? other.connectionColor_.Clone() : null;
      thickness_ = other.thickness_;
      visualizeLandmarkDepth_ = other.visualizeLandmarkDepth_;
      utilizeVisibility_ = other.utilizeVisibility_;
      visibilityThreshold_ = other.visibilityThreshold_;
      utilizePresence_ = other.utilizePresence_;
      presenceThreshold_ = other.presenceThreshold_;
      minDepthCircleThickness_ = other.minDepthCircleThickness_;
      maxDepthCircleThickness_ = other.maxDepthCircleThickness_;
      minDepthLineColor_ = other.minDepthLineColor_ != null ? other.minDepthLineColor_.Clone() : null;
      maxDepthLineColor_ = other.maxDepthLineColor_ != null ? other.maxDepthLineColor_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LandmarksToRenderDataCalculatorOptions Clone() {
      return new LandmarksToRenderDataCalculatorOptions(this);
    }

    /// <summary>Field number for the "landmark_connections" field.</summary>
    public const int LandmarkConnectionsFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_landmarkConnections_codec
        = pb::FieldCodec.ForInt32(8);
    private readonly pbc::RepeatedField<int> landmarkConnections_ = new pbc::RepeatedField<int>();
    /// <summary>
    /// Specifies the landmarks to be connected in the drawing. For example, the
    /// landmark_connections value of [0, 1, 1, 2] specifies two connections: one
    /// that connects landmarks with index 0 and 1, and another that connects
    /// landmarks with index 1 and 2.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> LandmarkConnections {
      get { return landmarkConnections_; }
    }

    /// <summary>Field number for the "landmark_color" field.</summary>
    public const int LandmarkColorFieldNumber = 2;
    private global::Mediapipe.Color landmarkColor_;
    /// <summary>
    /// Color of the landmarks.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Color LandmarkColor {
      get { return landmarkColor_; }
      set {
        landmarkColor_ = value;
      }
    }

    /// <summary>Field number for the "connection_color" field.</summary>
    public const int ConnectionColorFieldNumber = 3;
    private global::Mediapipe.Color connectionColor_;
    /// <summary>
    /// Color of the connections.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Color ConnectionColor {
      get { return connectionColor_; }
      set {
        connectionColor_ = value;
      }
    }

    /// <summary>Field number for the "thickness" field.</summary>
    public const int ThicknessFieldNumber = 4;
    private readonly static double ThicknessDefaultValue = 1D;

    private double thickness_;
    /// <summary>
    /// Thickness of the drawing of landmarks and connections.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Thickness {
      get { if ((_hasBits0 & 1) != 0) { return thickness_; } else { return ThicknessDefaultValue; } }
      set {
        _hasBits0 |= 1;
        thickness_ = value;
      }
    }
    /// <summary>Gets whether the "thickness" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasThickness {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "thickness" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearThickness() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "visualize_landmark_depth" field.</summary>
    public const int VisualizeLandmarkDepthFieldNumber = 5;
    private readonly static bool VisualizeLandmarkDepthDefaultValue = true;

    private bool visualizeLandmarkDepth_;
    /// <summary>
    /// Change color and size of rendered landmarks based on its z value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool VisualizeLandmarkDepth {
      get { if ((_hasBits0 & 2) != 0) { return visualizeLandmarkDepth_; } else { return VisualizeLandmarkDepthDefaultValue; } }
      set {
        _hasBits0 |= 2;
        visualizeLandmarkDepth_ = value;
      }
    }
    /// <summary>Gets whether the "visualize_landmark_depth" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasVisualizeLandmarkDepth {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "visualize_landmark_depth" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearVisualizeLandmarkDepth() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "utilize_visibility" field.</summary>
    public const int UtilizeVisibilityFieldNumber = 6;
    private readonly static bool UtilizeVisibilityDefaultValue = false;

    private bool utilizeVisibility_;
    /// <summary>
    /// Use landmarks visibility while rendering landmarks and connections. If
    /// landmark is not visible, neither it nor adjacent connections will be
    /// rendered.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UtilizeVisibility {
      get { if ((_hasBits0 & 4) != 0) { return utilizeVisibility_; } else { return UtilizeVisibilityDefaultValue; } }
      set {
        _hasBits0 |= 4;
        utilizeVisibility_ = value;
      }
    }
    /// <summary>Gets whether the "utilize_visibility" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasUtilizeVisibility {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "utilize_visibility" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUtilizeVisibility() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "visibility_threshold" field.</summary>
    public const int VisibilityThresholdFieldNumber = 7;
    private readonly static double VisibilityThresholdDefaultValue = 0D;

    private double visibilityThreshold_;
    /// <summary>
    /// Threshold to determine visibility of the landmark. Landmark with visibility
    /// greater or equal than threshold is considered visible.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double VisibilityThreshold {
      get { if ((_hasBits0 & 8) != 0) { return visibilityThreshold_; } else { return VisibilityThresholdDefaultValue; } }
      set {
        _hasBits0 |= 8;
        visibilityThreshold_ = value;
      }
    }
    /// <summary>Gets whether the "visibility_threshold" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasVisibilityThreshold {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "visibility_threshold" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearVisibilityThreshold() {
      _hasBits0 &= ~8;
    }

    /// <summary>Field number for the "utilize_presence" field.</summary>
    public const int UtilizePresenceFieldNumber = 8;
    private readonly static bool UtilizePresenceDefaultValue = false;

    private bool utilizePresence_;
    /// <summary>
    /// Use landmarks presence while rendering landmarks and connections. If
    /// landmark is not present, neither it nor adjacent connections will be
    /// rendered.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UtilizePresence {
      get { if ((_hasBits0 & 16) != 0) { return utilizePresence_; } else { return UtilizePresenceDefaultValue; } }
      set {
        _hasBits0 |= 16;
        utilizePresence_ = value;
      }
    }
    /// <summary>Gets whether the "utilize_presence" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasUtilizePresence {
      get { return (_hasBits0 & 16) != 0; }
    }
    /// <summary>Clears the value of the "utilize_presence" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUtilizePresence() {
      _hasBits0 &= ~16;
    }

    /// <summary>Field number for the "presence_threshold" field.</summary>
    public const int PresenceThresholdFieldNumber = 9;
    private readonly static double PresenceThresholdDefaultValue = 0D;

    private double presenceThreshold_;
    /// <summary>
    /// Threshold to determine presence of the landmark. Landmark with presence
    /// greater or equal than threshold is considered present.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double PresenceThreshold {
      get { if ((_hasBits0 & 32) != 0) { return presenceThreshold_; } else { return PresenceThresholdDefaultValue; } }
      set {
        _hasBits0 |= 32;
        presenceThreshold_ = value;
      }
    }
    /// <summary>Gets whether the "presence_threshold" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPresenceThreshold {
      get { return (_hasBits0 & 32) != 0; }
    }
    /// <summary>Clears the value of the "presence_threshold" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPresenceThreshold() {
      _hasBits0 &= ~32;
    }

    /// <summary>Field number for the "min_depth_circle_thickness" field.</summary>
    public const int MinDepthCircleThicknessFieldNumber = 10;
    private readonly static double MinDepthCircleThicknessDefaultValue = 0D;

    private double minDepthCircleThickness_;
    /// <summary>
    /// Min thickness of the drawing for landmark circle.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double MinDepthCircleThickness {
      get { if ((_hasBits0 & 64) != 0) { return minDepthCircleThickness_; } else { return MinDepthCircleThicknessDefaultValue; } }
      set {
        _hasBits0 |= 64;
        minDepthCircleThickness_ = value;
      }
    }
    /// <summary>Gets whether the "min_depth_circle_thickness" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMinDepthCircleThickness {
      get { return (_hasBits0 & 64) != 0; }
    }
    /// <summary>Clears the value of the "min_depth_circle_thickness" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMinDepthCircleThickness() {
      _hasBits0 &= ~64;
    }

    /// <summary>Field number for the "max_depth_circle_thickness" field.</summary>
    public const int MaxDepthCircleThicknessFieldNumber = 11;
    private readonly static double MaxDepthCircleThicknessDefaultValue = 18D;

    private double maxDepthCircleThickness_;
    /// <summary>
    /// Max thickness of the drawing for landmark circle.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double MaxDepthCircleThickness {
      get { if ((_hasBits0 & 128) != 0) { return maxDepthCircleThickness_; } else { return MaxDepthCircleThicknessDefaultValue; } }
      set {
        _hasBits0 |= 128;
        maxDepthCircleThickness_ = value;
      }
    }
    /// <summary>Gets whether the "max_depth_circle_thickness" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMaxDepthCircleThickness {
      get { return (_hasBits0 & 128) != 0; }
    }
    /// <summary>Clears the value of the "max_depth_circle_thickness" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMaxDepthCircleThickness() {
      _hasBits0 &= ~128;
    }

    /// <summary>Field number for the "min_depth_line_color" field.</summary>
    public const int MinDepthLineColorFieldNumber = 12;
    private global::Mediapipe.Color minDepthLineColor_;
    /// <summary>
    /// Gradient color for the lines connecting landmarks at the minimum depth.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Color MinDepthLineColor {
      get { return minDepthLineColor_; }
      set {
        minDepthLineColor_ = value;
      }
    }

    /// <summary>Field number for the "max_depth_line_color" field.</summary>
    public const int MaxDepthLineColorFieldNumber = 13;
    private global::Mediapipe.Color maxDepthLineColor_;
    /// <summary>
    /// Gradient color for the lines connecting landmarks at the maximum depth.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Color MaxDepthLineColor {
      get { return maxDepthLineColor_; }
      set {
        maxDepthLineColor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LandmarksToRenderDataCalculatorOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LandmarksToRenderDataCalculatorOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!landmarkConnections_.Equals(other.landmarkConnections_)) return false;
      if (!object.Equals(LandmarkColor, other.LandmarkColor)) return false;
      if (!object.Equals(ConnectionColor, other.ConnectionColor)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Thickness, other.Thickness)) return false;
      if (VisualizeLandmarkDepth != other.VisualizeLandmarkDepth) return false;
      if (UtilizeVisibility != other.UtilizeVisibility) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(VisibilityThreshold, other.VisibilityThreshold)) return false;
      if (UtilizePresence != other.UtilizePresence) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PresenceThreshold, other.PresenceThreshold)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MinDepthCircleThickness, other.MinDepthCircleThickness)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxDepthCircleThickness, other.MaxDepthCircleThickness)) return false;
      if (!object.Equals(MinDepthLineColor, other.MinDepthLineColor)) return false;
      if (!object.Equals(MaxDepthLineColor, other.MaxDepthLineColor)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= landmarkConnections_.GetHashCode();
      if (landmarkColor_ != null) hash ^= LandmarkColor.GetHashCode();
      if (connectionColor_ != null) hash ^= ConnectionColor.GetHashCode();
      if (HasThickness) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Thickness);
      if (HasVisualizeLandmarkDepth) hash ^= VisualizeLandmarkDepth.GetHashCode();
      if (HasUtilizeVisibility) hash ^= UtilizeVisibility.GetHashCode();
      if (HasVisibilityThreshold) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(VisibilityThreshold);
      if (HasUtilizePresence) hash ^= UtilizePresence.GetHashCode();
      if (HasPresenceThreshold) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PresenceThreshold);
      if (HasMinDepthCircleThickness) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MinDepthCircleThickness);
      if (HasMaxDepthCircleThickness) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxDepthCircleThickness);
      if (minDepthLineColor_ != null) hash ^= MinDepthLineColor.GetHashCode();
      if (maxDepthLineColor_ != null) hash ^= MaxDepthLineColor.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      landmarkConnections_.WriteTo(output, _repeated_landmarkConnections_codec);
      if (landmarkColor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LandmarkColor);
      }
      if (connectionColor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ConnectionColor);
      }
      if (HasThickness) {
        output.WriteRawTag(33);
        output.WriteDouble(Thickness);
      }
      if (HasVisualizeLandmarkDepth) {
        output.WriteRawTag(40);
        output.WriteBool(VisualizeLandmarkDepth);
      }
      if (HasUtilizeVisibility) {
        output.WriteRawTag(48);
        output.WriteBool(UtilizeVisibility);
      }
      if (HasVisibilityThreshold) {
        output.WriteRawTag(57);
        output.WriteDouble(VisibilityThreshold);
      }
      if (HasUtilizePresence) {
        output.WriteRawTag(64);
        output.WriteBool(UtilizePresence);
      }
      if (HasPresenceThreshold) {
        output.WriteRawTag(73);
        output.WriteDouble(PresenceThreshold);
      }
      if (HasMinDepthCircleThickness) {
        output.WriteRawTag(81);
        output.WriteDouble(MinDepthCircleThickness);
      }
      if (HasMaxDepthCircleThickness) {
        output.WriteRawTag(89);
        output.WriteDouble(MaxDepthCircleThickness);
      }
      if (minDepthLineColor_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(MinDepthLineColor);
      }
      if (maxDepthLineColor_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(MaxDepthLineColor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      landmarkConnections_.WriteTo(ref output, _repeated_landmarkConnections_codec);
      if (landmarkColor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LandmarkColor);
      }
      if (connectionColor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ConnectionColor);
      }
      if (HasThickness) {
        output.WriteRawTag(33);
        output.WriteDouble(Thickness);
      }
      if (HasVisualizeLandmarkDepth) {
        output.WriteRawTag(40);
        output.WriteBool(VisualizeLandmarkDepth);
      }
      if (HasUtilizeVisibility) {
        output.WriteRawTag(48);
        output.WriteBool(UtilizeVisibility);
      }
      if (HasVisibilityThreshold) {
        output.WriteRawTag(57);
        output.WriteDouble(VisibilityThreshold);
      }
      if (HasUtilizePresence) {
        output.WriteRawTag(64);
        output.WriteBool(UtilizePresence);
      }
      if (HasPresenceThreshold) {
        output.WriteRawTag(73);
        output.WriteDouble(PresenceThreshold);
      }
      if (HasMinDepthCircleThickness) {
        output.WriteRawTag(81);
        output.WriteDouble(MinDepthCircleThickness);
      }
      if (HasMaxDepthCircleThickness) {
        output.WriteRawTag(89);
        output.WriteDouble(MaxDepthCircleThickness);
      }
      if (minDepthLineColor_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(MinDepthLineColor);
      }
      if (maxDepthLineColor_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(MaxDepthLineColor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += landmarkConnections_.CalculateSize(_repeated_landmarkConnections_codec);
      if (landmarkColor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LandmarkColor);
      }
      if (connectionColor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConnectionColor);
      }
      if (HasThickness) {
        size += 1 + 8;
      }
      if (HasVisualizeLandmarkDepth) {
        size += 1 + 1;
      }
      if (HasUtilizeVisibility) {
        size += 1 + 1;
      }
      if (HasVisibilityThreshold) {
        size += 1 + 8;
      }
      if (HasUtilizePresence) {
        size += 1 + 1;
      }
      if (HasPresenceThreshold) {
        size += 1 + 8;
      }
      if (HasMinDepthCircleThickness) {
        size += 1 + 8;
      }
      if (HasMaxDepthCircleThickness) {
        size += 1 + 8;
      }
      if (minDepthLineColor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MinDepthLineColor);
      }
      if (maxDepthLineColor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaxDepthLineColor);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LandmarksToRenderDataCalculatorOptions other) {
      if (other == null) {
        return;
      }
      landmarkConnections_.Add(other.landmarkConnections_);
      if (other.landmarkColor_ != null) {
        if (landmarkColor_ == null) {
          LandmarkColor = new global::Mediapipe.Color();
        }
        LandmarkColor.MergeFrom(other.LandmarkColor);
      }
      if (other.connectionColor_ != null) {
        if (connectionColor_ == null) {
          ConnectionColor = new global::Mediapipe.Color();
        }
        ConnectionColor.MergeFrom(other.ConnectionColor);
      }
      if (other.HasThickness) {
        Thickness = other.Thickness;
      }
      if (other.HasVisualizeLandmarkDepth) {
        VisualizeLandmarkDepth = other.VisualizeLandmarkDepth;
      }
      if (other.HasUtilizeVisibility) {
        UtilizeVisibility = other.UtilizeVisibility;
      }
      if (other.HasVisibilityThreshold) {
        VisibilityThreshold = other.VisibilityThreshold;
      }
      if (other.HasUtilizePresence) {
        UtilizePresence = other.UtilizePresence;
      }
      if (other.HasPresenceThreshold) {
        PresenceThreshold = other.PresenceThreshold;
      }
      if (other.HasMinDepthCircleThickness) {
        MinDepthCircleThickness = other.MinDepthCircleThickness;
      }
      if (other.HasMaxDepthCircleThickness) {
        MaxDepthCircleThickness = other.MaxDepthCircleThickness;
      }
      if (other.minDepthLineColor_ != null) {
        if (minDepthLineColor_ == null) {
          MinDepthLineColor = new global::Mediapipe.Color();
        }
        MinDepthLineColor.MergeFrom(other.MinDepthLineColor);
      }
      if (other.maxDepthLineColor_ != null) {
        if (maxDepthLineColor_ == null) {
          MaxDepthLineColor = new global::Mediapipe.Color();
        }
        MaxDepthLineColor.MergeFrom(other.MaxDepthLineColor);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            landmarkConnections_.AddEntriesFrom(input, _repeated_landmarkConnections_codec);
            break;
          }
          case 18: {
            if (landmarkColor_ == null) {
              LandmarkColor = new global::Mediapipe.Color();
            }
            input.ReadMessage(LandmarkColor);
            break;
          }
          case 26: {
            if (connectionColor_ == null) {
              ConnectionColor = new global::Mediapipe.Color();
            }
            input.ReadMessage(ConnectionColor);
            break;
          }
          case 33: {
            Thickness = input.ReadDouble();
            break;
          }
          case 40: {
            VisualizeLandmarkDepth = input.ReadBool();
            break;
          }
          case 48: {
            UtilizeVisibility = input.ReadBool();
            break;
          }
          case 57: {
            VisibilityThreshold = input.ReadDouble();
            break;
          }
          case 64: {
            UtilizePresence = input.ReadBool();
            break;
          }
          case 73: {
            PresenceThreshold = input.ReadDouble();
            break;
          }
          case 81: {
            MinDepthCircleThickness = input.ReadDouble();
            break;
          }
          case 89: {
            MaxDepthCircleThickness = input.ReadDouble();
            break;
          }
          case 98: {
            if (minDepthLineColor_ == null) {
              MinDepthLineColor = new global::Mediapipe.Color();
            }
            input.ReadMessage(MinDepthLineColor);
            break;
          }
          case 106: {
            if (maxDepthLineColor_ == null) {
              MaxDepthLineColor = new global::Mediapipe.Color();
            }
            input.ReadMessage(MaxDepthLineColor);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10:
          case 8: {
            landmarkConnections_.AddEntriesFrom(ref input, _repeated_landmarkConnections_codec);
            break;
          }
          case 18: {
            if (landmarkColor_ == null) {
              LandmarkColor = new global::Mediapipe.Color();
            }
            input.ReadMessage(LandmarkColor);
            break;
          }
          case 26: {
            if (connectionColor_ == null) {
              ConnectionColor = new global::Mediapipe.Color();
            }
            input.ReadMessage(ConnectionColor);
            break;
          }
          case 33: {
            Thickness = input.ReadDouble();
            break;
          }
          case 40: {
            VisualizeLandmarkDepth = input.ReadBool();
            break;
          }
          case 48: {
            UtilizeVisibility = input.ReadBool();
            break;
          }
          case 57: {
            VisibilityThreshold = input.ReadDouble();
            break;
          }
          case 64: {
            UtilizePresence = input.ReadBool();
            break;
          }
          case 73: {
            PresenceThreshold = input.ReadDouble();
            break;
          }
          case 81: {
            MinDepthCircleThickness = input.ReadDouble();
            break;
          }
          case 89: {
            MaxDepthCircleThickness = input.ReadDouble();
            break;
          }
          case 98: {
            if (minDepthLineColor_ == null) {
              MinDepthLineColor = new global::Mediapipe.Color();
            }
            input.ReadMessage(MinDepthLineColor);
            break;
          }
          case 106: {
            if (maxDepthLineColor_ == null) {
              MaxDepthLineColor = new global::Mediapipe.Color();
            }
            input.ReadMessage(MaxDepthLineColor);
            break;
          }
        }
      }
    }
    #endif

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the LandmarksToRenderDataCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.LandmarksToRenderDataCalculatorOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.LandmarksToRenderDataCalculatorOptions>(258435389, pb::FieldCodec.ForMessage(2067483114, global::Mediapipe.LandmarksToRenderDataCalculatorOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code