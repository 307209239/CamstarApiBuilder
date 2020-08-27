// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeLoginInfoChanges
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
  public class EmployeeLoginInfoChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_LastLoginDateGMT")]
    protected Primitive<DateTime> _LastLoginDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is EmployeeLoginInfoChanges && object.Equals((object) this._ChangeHistory, (object) ((EmployeeLoginInfoChanges) obj)._ChangeHistory) && (object.Equals((object) this._ObjectToChange, (object) ((EmployeeLoginInfoChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((EmployeeLoginInfoChanges) obj)._ListItemToChange)) && (object.Equals((object) this._LastLoginDateGMT, (object) ((EmployeeLoginInfoChanges) obj)._LastLoginDateGMT) && object.Equals((object) this._IsFrozen, (object) ((EmployeeLoginInfoChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public ChangeHistoryChanges ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges) this.PropertyGet(nameof (ChangeHistory));
      }
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

    public Primitive<DateTime> LastLoginDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastLoginDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastLoginDateGMT));
      }
    }

    public Primitive<bool> IsFrozen
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
