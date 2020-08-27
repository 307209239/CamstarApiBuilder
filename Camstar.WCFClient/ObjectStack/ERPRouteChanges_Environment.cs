// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPRouteChanges_Environment
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
  public class ERPRouteChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a mirror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRoute", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Environment_Base")]
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a miiror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRouteBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStepChanges", false, false, false, "NamedSubentityRef", 1049927, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Environment_RouteStepItem")]
    protected Environment _RouteStepItem;
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStepChanges", false, false, false, "RouteStepChanges", 1049915, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Environment_RouteSteps")]
    protected RouteStepChanges_Environment _RouteSteps;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Environment_ERPItem")]
    [Metadata("Generic String", "", false, false, false, "String", 1049918, false, false, false, null)]
    protected Environment _ERPItem;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050230, false, false, false, null)]
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

    public Environment RouteStepItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStepItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RouteStepItem));
      }
    }

    public RouteStepChanges_Environment RouteSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteSteps), (object) value);
      }
      get
      {
        return (RouteStepChanges_Environment) this.PropertyGet(nameof (RouteSteps));
      }
    }

    public Environment ERPItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPItem));
      }
    }

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
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
