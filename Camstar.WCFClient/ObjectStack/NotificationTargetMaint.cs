// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NotificationTargetMaint
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
  public class NotificationTargetMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetMaint_ObjectChanges")]
    protected NotificationTargetChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is NotificationTargetMaint && object.Equals((object) this._ObjectChanges, (object) ((NotificationTargetMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((NotificationTargetMaint) obj)._ObjectToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((NotificationTargetMaint) obj)._ObjectListInquiry)) && base.Equals(obj);
    }

    public NotificationTargetChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NotificationTargetChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
