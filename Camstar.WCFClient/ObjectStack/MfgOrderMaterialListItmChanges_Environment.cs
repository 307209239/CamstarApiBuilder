// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgOrderMaterialListItmChanges_Environment
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
  public class MfgOrderMaterialListItmChanges_Environment : ERPMaterialListItemChanges_Environment
  {
    [Metadata("Represents a particular material that is required to complete a given manufacturing or assembly step, as defined by the ERP RouteStep refenced in the current WorkflowStep of the container.  The necessary quantities or proportions of the item are specified as are the appropriate units of measure.  This particular type of material list item is used on Mfg orders, and was created so that MfgOrder component lists could be stored in a separate table from BOM or Container component lists.", "MfgOrderMaterialListItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderMaterialListItmChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Represents a particular material that is required to complete a given manufacturing or assembly step, as defined by the ERP RouteStep refenced in the current WorkflowStep of the container.  The necessary quantities or proportions of the item are specified as are the appropriate units of measure.  This particular type of material list item is used on Mfg orders, and was created so that MfgOrder component lists could be stored in a separate table from BOM or Container component lists.", "MfgOrderMaterialListItmChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderMaterialListItmChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStep", false, false, false, "NamedSubentityRef", 1049917, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderMaterialListItmChanges_Environment_RouteStep")]
    protected new Environment _RouteStep;
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, true, false, "Integer", 1049491, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderMaterialListItmChanges_Environment_IssueControl")]
    protected new Environment _IssueControl;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051652, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderMaterialListItmChanges_Environment_Name")]
    protected new Environment _Name;

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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RouteStep));
      }
    }

    public new Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
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
