// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnMap_Environment
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
  public class TxnMap_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, true, "RevisionedObjectRef", 1048868, false, false, false, null)]
    protected Environment _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1048909, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Environment_TxnType")]
    protected Environment _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Environment_Required")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049018, false, false, false, "0")]
    protected Environment _Required;
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1049019, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Environment_TxnToUse")]
    protected Environment _TxnToUse;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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
