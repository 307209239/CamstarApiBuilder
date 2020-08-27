// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleStatusCodeMaint_Environment
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
  public class ScaleStatusCodeMaint_Environment : ResourceStatusCodeMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ScaleStatusCodeMaint_Environment_ObjectListInquiry")]
    [Metadata("A Scale Status Code provides a description of the current status for a Scale.", "ScaleStatusCode", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("A Scale Status Code provides a description of the current status for a Scale.", "ScaleStatusCodeChanges", false, false, false, "ScaleStatusCodeChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleStatusCodeMaint_Environment_ObjectChanges")]
    protected ScaleStatusCodeChanges_Environment _ObjectChanges;
    [Metadata("A Scale Status Code provides a description of the current status for a Scale.", "ScaleStatusCode", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleStatusCodeMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

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

    public ScaleStatusCodeChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ScaleStatusCodeChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
