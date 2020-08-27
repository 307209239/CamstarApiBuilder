// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollection_Environment
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
  public class DataPointCollection_Environment : NamedSubentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Environment_Groups")]
    [Metadata("A DataPointCollectionGroup contains a list of DataPointColletionPoint objects to be collected.  The data points may be related to each other, and presented in a vertical or horizontal format, or unrelated (Unassociated) and presented individually.", "DataPointCollectionGroup", false, false, true, "DataPointCollectionGroup", 1052432, false, true, false, null)]
    protected DataPointCollectionGroup_Environment _Groups;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052415, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1051642, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Environment_Instructions")]
    protected Environment _Instructions;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Environment_IsFrozen")]
    protected new Environment _IsFrozen;

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

    public DataPointCollectionGroup_Environment Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (DataPointCollectionGroup_Environment) this.PropertyGet(nameof (Groups));
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

    public Environment Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Instructions));
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
  }
}
