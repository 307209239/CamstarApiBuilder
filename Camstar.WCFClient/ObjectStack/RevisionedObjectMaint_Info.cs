// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObjectMaint_Info
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
  public class RevisionedObjectMaint_Info : Maintenance_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Info_ObjectChanges")]
    protected RevisionedObjectChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Info_BaseToChange")]
    protected Info _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Info_SyncRevision")]
    protected Info _SyncRevision;

    public RevisionedObjectChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RevisionedObjectChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public Info SyncRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SyncRevision));
      }
    }
  }
}
