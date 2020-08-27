// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Split_Environment
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
  public class Split_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Split_Environment_ToContainerDetails")]
    [Metadata("Split details", "SplitDetails", false, false, false, "SplitDetails", 1049401, false, true, false, null)]
    protected SplitDetails_Environment _ToContainerDetails;
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, true, "NamedObjectRef", 1051465, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Split_Environment_AutoNumberRule")]
    protected Environment _AutoNumberRule;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778905, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Split_Environment_AutoNumber")]
    protected Environment _AutoNumber;
    [DataMember(EmitDefaultValue = false, Name = "Split_Environment_CloseWhenEmpty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049402, false, false, false, "0")]
    protected Environment _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "Split_Environment_ChildContainers")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1048769, false, true, true, null)]
    protected Environment _ChildContainers;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051471, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "Split_Environment_AllowZeroQtys")]
    protected Environment _AllowZeroQtys;
    [Metadata("Generic String", "", false, false, false, "String", 1048741, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Split_Environment_ToContainerName")]
    protected Environment _ToContainerName;
    [Metadata("A Document Entry is used to include a Document in a Document and provide a description for it within the Document Set. If there is more than one Document within a Document Set when a request is made to display a Document Set, the list of Document Entries is used to build a selection list. (Note that a one-to-one relationship between a Document Set and a Document is likely the common scenario).", "DocumentEntry", false, false, false, "NamedSubentityRef", 16777567, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Split_Environment_Documents")]
    protected Environment _Documents;

    public SplitDetails_Environment ToContainerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerDetails), (object) value);
      }
      get
      {
        return (SplitDetails_Environment) this.PropertyGet(nameof (ToContainerDetails));
      }
    }

    public Environment AutoNumberRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumberRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoNumberRule));
      }
    }

    public Environment AutoNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoNumber));
      }
    }

    public Environment CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Environment ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Environment AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public Environment ToContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToContainerName));
      }
    }

    public Environment Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Documents));
      }
    }
  }
}
