// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserDataCollectionDefMaint
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
  public class UserDataCollectionDefMaint : DataCollectionDefMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefMaint_ObjectChanges")]
    protected UserDataCollectionDefChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is UserDataCollectionDefMaint && object.Equals((object) this._ObjectToChange, (object) ((UserDataCollectionDefMaint) obj)._ObjectToChange) && (object.Equals((object) this._BaseToChange, (object) ((UserDataCollectionDefMaint) obj)._BaseToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((UserDataCollectionDefMaint) obj)._ObjectListInquiry)) && object.Equals((object) this._ObjectChanges, (object) ((UserDataCollectionDefMaint) obj)._ObjectChanges) && base.Equals(obj);
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public new RevisionedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public UserDataCollectionDefChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UserDataCollectionDefChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
