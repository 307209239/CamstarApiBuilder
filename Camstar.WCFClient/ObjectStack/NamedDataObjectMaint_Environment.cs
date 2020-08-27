// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedDataObjectMaint_Environment
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
  public class NamedDataObjectMaint_Environment : Maintenance_Environment
  {
    [Metadata("This CDO holds the changes that are being made to the Object until the user decides to make them permanent.", "NamedDataObjectChanges", false, false, false, "NamedDataObjectChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectMaint_Environment_ObjectChanges")]
    protected NamedDataObjectChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectMaint_Environment_ObjectListInquiry")]
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectMaint_Environment_SyncName")]
    [Metadata("Generic String", "", false, false, false, "String", 1050975, false, false, false, null)]
    protected new Environment _SyncName;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectMaint_Environment_ObjectToChange")]
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public NamedDataObjectChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NamedDataObjectChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public new Environment SyncName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SyncName));
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
