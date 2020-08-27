// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Bin_Environment
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
  public class Bin_Environment : NamedSubentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_EffectiveFromDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049026, false, false, false, null)]
    protected Environment _EffectiveFromDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049028, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_EffectiveThruDateGMT")]
    protected Environment _EffectiveThruDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049027, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_EffectiveThruDate")]
    protected Environment _EffectiveThruDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048744, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_EffectiveFromDate")]
    protected Environment _EffectiveFromDate;
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_Status")]
    protected Environment _Status;
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nTransaction details are used to define the type of processing (transaction type) required to \"move-down\" a Path. This is used to define, for example, whether a Move or a Combine transaction is to be used. Each Path has an associated Transaction Details entry. This is used when the Path is selected directly. Bins and other entities that can be used to select a Path also have their own associated Transaction Details (which overrides the Transaction Details for the Path).", "TxnDetails", false, false, true, "TxnDetails", 1048930, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_TxnDetails")]
    protected TxnDetails_Environment _TxnDetails;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1049032, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_Step")]
    protected Environment _Step;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_FromProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1049029, false, false, false, null)]
    protected Environment _FromProduct;
    [Metadata("Percentage", "", false, false, true, "Fixed", 1049025, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_BinPercentage")]
    protected Environment _BinPercentage;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_ResultingProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1049031, false, false, false, null)]
    protected Environment _ResultingProduct;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050247, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "MovePath", false, false, true, "NamedSubentityRef", 1049030, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_Path")]
    protected Environment _Path;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Bin_Environment_Notes")]
    protected Environment _Notes;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Environment EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Environment EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Environment EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Environment Status
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

    public TxnDetails_Environment TxnDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDetails), (object) value);
      }
      get
      {
        return (TxnDetails_Environment) this.PropertyGet(nameof (TxnDetails));
      }
    }

    public Environment Description
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

    public Environment Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Step));
      }
    }

    public Environment FromProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromProduct), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromProduct));
      }
    }

    public Environment BinPercentage
    {
      [param: In] set
      {
        this.PropertySet(nameof (BinPercentage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BinPercentage));
      }
    }

    public Environment ResultingProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultingProduct), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultingProduct));
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

    public Environment Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Path));
      }
    }

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
