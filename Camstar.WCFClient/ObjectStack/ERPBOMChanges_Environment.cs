// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPBOMChanges_Environment
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
  public class ERPBOMChanges_Environment : BillChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_Base")]
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOMBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a mirror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRoute", false, false, false, "RevisionedObjectRef", 1049919, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_ERPRoute")]
    protected Environment _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_MaterialListItem")]
    [Metadata("Represents a particular material that is required to complete a given manufacturing or assembly step, as defined by the ERP RouteStep refenced in the current WorkflowStep of the container.  The necessary quantities or proportions of the item are specified as are the appropriate units of measure.  This particular type of material list item is used on ERPBOMs, which are BOMs created by the ERPsystem and downloaded to InSite.  This particular object type was created so that BOM component lists could be stored in a separate table from MfgOrder or Container component lists.", "BOMMaterialListItemChanges", false, false, false, "BOMMaterialListItemChanges", 1049721, true, false, false, null)]
    protected BOMMaterialListItemChanges_Environment _MaterialListItem;
    [Metadata("Represents a particular material that is required to complete a given manufacturing or assembly step, as defined by the ERP RouteStep refenced in the current WorkflowStep of the container.  The necessary quantities or proportions of the item are specified as are the appropriate units of measure.  This particular type of material list item is used on ERPBOMs, which are BOMs created by the ERPsystem and downloaded to InSite.  This particular object type was created so that BOM component lists could be stored in a separate table from MfgOrder or Container component lists.", "BOMMaterialListItemChanges", false, false, false, "BOMMaterialListItemChanges", 1049427, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_MaterialList")]
    protected BOMMaterialListItemChanges_Environment _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_ObjectToChange")]
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOM", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_ExternallyControlled")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050310, false, false, false, "0")]
    protected Environment _ExternallyControlled;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050226, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_Description")]
    protected new Environment _Description;
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_IsRevOfRcd")]
    protected new Environment _IsRevOfRcd;
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, false, "Integer", 1048671, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Environment_Status")]
    protected new Environment _Status;

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

    public Environment ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public BOMMaterialListItemChanges_Environment MaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialListItem), (object) value);
      }
      get
      {
        return (BOMMaterialListItemChanges_Environment) this.PropertyGet(nameof (MaterialListItem));
      }
    }

    public BOMMaterialListItemChanges_Environment MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (BOMMaterialListItemChanges_Environment) this.PropertyGet(nameof (MaterialList));
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

    public Environment ExternallyControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternallyControlled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExternallyControlled));
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
  }
}
