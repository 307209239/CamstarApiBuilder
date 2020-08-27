// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnMapChanges_Environment
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
  public class TxnMapChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Environment_ListItemToChange")]
    [Metadata("Changes CDO for TxnMap.", "TxnMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, true, false, "RevisionedObjectRef", 1049433, false, false, true, null)]
    protected Environment _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Environment_ObjectToChange")]
    [Metadata("A Transaction Map is used within a Specification for three purposes. The first is to specify a User Defined transaction that is to take the place of a standard transaction. The second is to associate a Data Collection Definition to a transaction. The third is to determine which transactions (if any) must be performed and in what order, to consider the work complete (and allow a Move-out transaction).\r\n\r\nSequencing transactions and defining them as Required versus Optional is a simplistic approach to defining “What’s Next?” within a processing step. While this is more than adequate for a first release, this is an area where a more comprehensive approach (i.e., scripting logic) may be appropriate in future releases. Other similar areas include Instructions and Path Selection.", "TxnMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Environment_TxnToUse")]
    [Metadata("CDO Definition Id", "", false, true, false, "Integer", 1049019, false, false, true, null)]
    protected Environment _TxnToUse;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Environment_Required")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049018, false, false, false, "0")]
    protected Environment _Required;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049646, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Environment_TxnToUseName")]
    protected Environment _TxnToUseName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049647, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Environment_TxnName")]
    protected Environment _TxnName;

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
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

    public Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
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

    public Environment TxnToUse
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUse), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnToUse));
      }
    }

    public Environment Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Required), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Required));
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

    public Environment TxnToUseName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUseName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnToUseName));
      }
    }

    public Environment TxnName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnName));
      }
    }
  }
}
