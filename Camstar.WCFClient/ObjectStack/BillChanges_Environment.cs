// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillChanges_Environment
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
  public class BillChanges_Environment : RevisionedObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_ChangeHistory")]
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    protected new ChangeHistoryChanges_Environment _ChangeHistory;
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItemChanges", false, false, false, "MaterialListItemChanges", 1049721, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_MaterialListItem")]
    protected MaterialListItemChanges_Environment _MaterialListItem;
    [Metadata("Used to distinguish the intent of this Bill structure. Several Bills can exist for the same product. Bills can be at higher or lower levels of resolution depending on the department that is using the Bill. Items that are not physically part of the manufacturing process can be added to assist standard costing calculations or labor reporting.", "BillType", false, false, false, "NamedObjectRef", 1049428, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_BillType")]
    protected Environment _BillType;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_Base")]
    [Metadata("A Bill is  an enumerated, well defined list of raw materials, sub-assemblies, instructions, etc. ", "BillBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_WIPMsgDefMgr")]
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    protected new WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_ObjectToChange")]
    [Metadata("The idea behind a Bill is that manufactured products are built using  an enumerated, and well defined list of raw materials and sub-assemblies. These are called Material Lists. A Bill CDO allows a collection of Material Lists to be created.", "Bill", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_MaterialList")]
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItemChanges", false, false, false, "MaterialListItemChanges", 1049427, false, true, false, null)]
    protected MaterialListItemChanges_Environment _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_IsRevOfRcd")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "0")]
    protected new Environment _IsRevOfRcd;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, false, "Integer", 1048671, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_Status")]
    protected new Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected new Environment _Description;
    [Metadata("Revision (unique within the context of the base entity)", "", false, true, false, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_Revision")]
    protected new Environment _Revision;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050235, false, false, false, null)]
    protected new Environment _Name;

    public new ChangeHistoryChanges_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public MaterialListItemChanges_Environment MaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialListItem), (object) value);
      }
      get
      {
        return (MaterialListItemChanges_Environment) this.PropertyGet(nameof (MaterialListItem));
      }
    }

    public Environment BillType
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BillType));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public new WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
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

    public MaterialListItemChanges_Environment MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (MaterialListItemChanges_Environment) this.PropertyGet(nameof (MaterialList));
      }
    }

    public new Environment IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public new Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public new Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
