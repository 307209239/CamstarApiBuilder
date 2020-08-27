// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleMaint_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ScaleMaint_Environment : ResourceMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ScaleMaint_Environment_ObjectChanges")]
    [Metadata("Scale", "ScaleChanges", false, false, false, "ScaleChanges", 1048873, true, false, false, null)]
    protected ScaleChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ScaleMaint_Environment_ObjectListInquiry")]
    [Metadata("Scales are resources that provide information about calibration and setup, scale capabilities such as precision, and working range and connection information for device connectivity.", "Scale", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Scales are resources that provide information about calibration and setup, scale capabilities such as precision, and working range and connection information for device connectivity.", "Scale", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public ScaleChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ScaleChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
