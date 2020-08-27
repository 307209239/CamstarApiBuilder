// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserCodeWithWMMaint
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
  public class UserCodeWithWMMaint : UserCodeMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMMaint_ObjectChanges")]
    protected UserCodeWithWMChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is UserCodeWithWMMaint && object.Equals((object) this._ObjectChanges, (object) ((UserCodeWithWMMaint) obj)._ObjectChanges) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((UserCodeWithWMMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectToChange, (object) ((UserCodeWithWMMaint) obj)._ObjectToChange)) && base.Equals(obj);
    }

    public UserCodeWithWMChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UserCodeWithWMChanges) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
