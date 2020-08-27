// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelTxnMapChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (NCRLabelMapChanges_Environment))]
  [KnownType(typeof (PELabelMapChanges_Environment))]
  [KnownType(typeof (RecipeLabelMapChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (QualityObjectLabelMapChanges_Environment))]
  [KnownType(typeof (ContainerLabelMapChanges_Environment))]
  [Serializable]
  public class LabelTxnMapChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_Environment_LabelCount")]
    [Metadata("Field Expression.", "", false, true, false, "String", 1050617, false, false, false, null)]
    protected Environment _LabelCount;
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, true, false, "RevisionedObjectRef", 1050616, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_Environment_PrinterLabelDefinition")]
    protected Environment _PrinterLabelDefinition;
    [Metadata("Contains a match between a service and a label definition to be printed.", "LabelTxnMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO.  SubEntityChanges are used as temporary holding places while the parent CDO is undergoing maintenance.", "SubentityChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1048825, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_Environment_Parent")]
    protected new Environment _Parent;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1048909, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_Environment_TxnType")]
    protected Environment _TxnType;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelCount));
      }
    }

    public Environment PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrinterLabelDefinition));
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

    public new Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public Environment TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnType));
      }
    }

    public Environment IsFrozen
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
  }
}
