// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeHistory
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
  public class ChangeHistory : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_LastChangeDate")]
    protected Primitive<DateTime> _LastChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_LastChangeDateGMT")]
    protected Primitive<DateTime> _LastChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_User")]
    protected NamedObjectRef _User;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Control")]
    protected Primitive<int> _Control;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_CurrentStatus")]
    protected Primitive<int> _CurrentStatus;

    public override bool Equals(object obj)
    {
      return obj is ChangeHistory && object.Equals((object) this._ExportImportKey, (object) ((ChangeHistory) obj)._ExportImportKey) && (object.Equals((object) this._LastChangeDate, (object) ((ChangeHistory) obj)._LastChangeDate) && object.Equals((object) this._LastChangeDateGMT, (object) ((ChangeHistory) obj)._LastChangeDateGMT)) && (object.Equals((object) this._User, (object) ((ChangeHistory) obj)._User) && object.Equals((object) this._Notes, (object) ((ChangeHistory) obj)._Notes) && (object.Equals((object) this._Control, (object) ((ChangeHistory) obj)._Control) && object.Equals((object) this._IsFrozen, (object) ((ChangeHistory) obj)._IsFrozen))) && object.Equals((object) this._CurrentStatus, (object) ((ChangeHistory) obj)._CurrentStatus) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<DateTime> LastChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastChangeDate));
      }
    }

    public Primitive<DateTime> LastChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastChangeDateGMT));
      }
    }

    public NamedObjectRef User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (User));
      }
    }

    public Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public Primitive<int> Control
    {
      [param: In] set
      {
        this.PropertySet(nameof (Control), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Control));
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

    public Primitive<int> CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentStatus));
      }
    }
  }
}
