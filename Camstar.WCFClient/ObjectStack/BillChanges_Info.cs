// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillChanges_Info
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
  public class BillChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_ChangeHistory")]
    protected new ChangeHistoryChanges_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_MaterialListItem")]
    protected MaterialListItemChanges_Info _MaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_BillType")]
    protected Info _BillType;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_WIPMsgDefMgr")]
    protected new WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_MaterialList")]
    protected MaterialListItemChanges_Info _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_IsRevOfRcd")]
    protected new Info _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_Status")]
    protected new Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_Revision")]
    protected new Info _Revision;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Info_Name")]
    protected new Info _Name;

    public new ChangeHistoryChanges_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public MaterialListItemChanges_Info MaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialListItem), (object) value);
      }
      get
      {
        return (MaterialListItemChanges_Info) this.PropertyGet(nameof (MaterialListItem));
      }
    }

    public Info BillType
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BillType));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public new WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
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

    public MaterialListItemChanges_Info MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (MaterialListItemChanges_Info) this.PropertyGet(nameof (MaterialList));
      }
    }

    public new Info IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }

    public new Info IsFrozen
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

    public new Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public new Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public new Info Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Revision));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
