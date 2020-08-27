// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShiftMaint_Environment
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
  public class ShiftMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ShiftMaint_Environment_ObjectListInquiry")]
    [Metadata("Typically applies to manufacturing companies that have areas staffed for a long enough during a day that workers do not all start and end their day at the same time.  Shift is a mechanism for grouping production information based on management responsibilities for workers that start and leave at a particular time.  For example, the \"Day\" shift might work from 6am to 6pm, and the \"Night\" shift would work from 6pm to 6am. ", "Shift", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Typically applies to manufacturing companies that have areas staffed for a long enough during a day that workers do not all start and end their day at the same time.  Shift is a mechanism for grouping production information based on management responsibilities for workers that start and leave at a particular time.  For example, the \"Day\" shift might work from 6am to 6pm, and the \"Night\" shift would work from 6pm to 6am. ", "ShiftChanges", false, false, false, "ShiftChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShiftMaint_Environment_ObjectChanges")]
    protected ShiftChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ShiftMaint_Environment_ObjectToChange")]
    [Metadata("Typically applies to manufacturing companies that have areas staffed for a long enough during a day that workers do not all start and end their day at the same time.  Shift is a mechanism for grouping production information based on management responsibilities for workers that start and leave at a particular time.  For example, the \"Day\" shift might work from 6am to 6pm, and the \"Night\" shift would work from 6pm to 6am. ", "Shift", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
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

    public ShiftChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ShiftChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
