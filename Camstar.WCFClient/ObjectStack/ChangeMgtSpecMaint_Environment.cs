// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtSpecMaint_Environment
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
  public class ChangeMgtSpecMaint_Environment : BusinessProcessSpecMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecMaint_Environment_BaseToChange")]
    [Metadata("This specification (Spec) describes the processing that takes place at a Step within a Workflow for change management.", "ChangeMgtSpecBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecMaint_Environment_ObjectListInquiry")]
    [Metadata("This specification (Spec) describes the processing that takes place at a Step within a Workflow for change management.", "ChangeMgtSpecBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("This specification (Spec) describes the processing that takes place at a Step within a Workflow for change management.", "ChangeMgtSpec", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecMaint_Environment_ObjectChanges")]
    [Metadata("This specification (Spec) describes the processing that takes place at a Step within a Workflow for change management.", "ChangeMgtSpecChanges", false, false, false, "ChangeMgtSpecChanges", 1048873, true, false, false, null)]
    protected ChangeMgtSpecChanges_Environment _ObjectChanges;

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
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

    public ChangeMgtSpecChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ChangeMgtSpecChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
