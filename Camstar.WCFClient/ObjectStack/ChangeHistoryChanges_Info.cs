// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeHistoryChanges_Info
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
  public class ChangeHistoryChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Info_LastChangeDateGMT")]
    protected Info _LastChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Info_LastChangeDate")]
    protected Info _LastChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Info_CurrentStatus")]
    protected Info _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Info_User")]
    protected Info _User;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Info_Control")]
    protected Info _Control;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Info_Notes")]
    protected Info _Notes;

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info LastChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastChangeDateGMT));
      }
    }

    public Info LastChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastChangeDate));
      }
    }

    public Info CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
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

    public Info User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (User));
      }
    }

    public Info Control
    {
      [param: In] set
      {
        this.PropertySet(nameof (Control), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Control));
      }
    }

    public Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
