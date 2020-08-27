// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WhereUsedInquiry_Environment
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
  public class WhereUsedInquiry_Environment : Inquiry_Environment
  {
    [Metadata("A list of this type is returned by the Where-used functionality of a maintenance service.  An instance of this CDO will specify one of the objects using the object to change.  The fields in this CDO are used to populate a tree view displayed while maintaining a modeling object.", "WhereUsed", false, false, false, "SubentityRef", 1049803, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Environment_WhereUsedFiltered")]
    protected Environment _WhereUsedFiltered;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Environment_WhereUsed")]
    [Metadata("A list of this type is returned by the Where-used functionality of a maintenance service.  An instance of this CDO will specify one of the objects using the object to change.  The fields in this CDO are used to populate a tree view displayed while maintaining a modeling object.", "WhereUsed", false, false, false, "SubentityRef", 1049803, false, true, false, null)]
    protected Environment _WhereUsed;
    [Metadata("Configuration object used in object upward dependency search.", "WhereUsedConfig", false, false, false, "NamedObjectRef", 16778022, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Environment_WhereUsedConfig")]
    protected Environment _WhereUsedConfig;
    [Metadata("Attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.", "RevisionedObject", false, false, false, "RevisionedObjectRef", 16778056, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Environment_SelectedRevisionedObjects")]
    protected Environment _SelectedRevisionedObjects;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779002, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Environment_MaxNumberOfWhereUsedInstances")]
    protected Environment _MaxNumberOfWhereUsedInstances;
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, false, "NamedObjectRef", 16778141, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Environment_SelectedNamedObjects")]
    protected Environment _SelectedNamedObjects;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16779001, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Environment_IsChangeMgtSettingsRequired")]
    protected Environment _IsChangeMgtSettingsRequired;

    public Environment WhereUsedFiltered
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedFiltered), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WhereUsedFiltered));
      }
    }

    public Environment WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public Environment WhereUsedConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedConfig), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WhereUsedConfig));
      }
    }

    public Environment SelectedRevisionedObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedRevisionedObjects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedRevisionedObjects));
      }
    }

    public Environment MaxNumberOfWhereUsedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxNumberOfWhereUsedInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxNumberOfWhereUsedInstances));
      }
    }

    public Environment SelectedNamedObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedNamedObjects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedNamedObjects));
      }
    }

    public Environment IsChangeMgtSettingsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsChangeMgtSettingsRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsChangeMgtSettingsRequired));
      }
    }
  }
}
