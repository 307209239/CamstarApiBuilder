// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageApprovalReminderChanges
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
  public class PackageApprovalReminderChanges : EmailReminderChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageApprovalReminderChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PackageApprovalReminderChanges_Recipient")]
    protected Enumeration<PkgApprovalEnum, int> _Recipient;
    [DataMember(EmitDefaultValue = false, Name = "PackageApprovalReminderChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PackageApprovalReminderChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is PackageApprovalReminderChanges && object.Equals((object) this._ObjectToChange, (object) ((PackageApprovalReminderChanges) obj)._ObjectToChange) && (object.Equals((object) this._Recipient, (object) ((PackageApprovalReminderChanges) obj)._Recipient) && object.Equals((object) this._ListItemToChange, (object) ((PackageApprovalReminderChanges) obj)._ListItemToChange)) && object.Equals((object) this._IsFrozen, (object) ((PackageApprovalReminderChanges) obj)._IsFrozen) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Enumeration<PkgApprovalEnum, int> Recipient
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recipient), (object) value);
      }
      get
      {
        return (Enumeration<PkgApprovalEnum, int>) this.PropertyGet(nameof (Recipient));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
