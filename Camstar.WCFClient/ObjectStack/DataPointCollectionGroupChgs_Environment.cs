// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionGroupChgs_Environment
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
  public class DataPointCollectionGroupChgs_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Environment_GroupLayout")]
    [Metadata("Enumeration for the Data Point Collection Group Layout:\r\n1 = Vertical\r\n2 = Horizontal\r\n3 = Unassociated", "DPCollectionGroupLayoutEnum", false, false, false, "Integer", 1052427, false, false, true, null)]
    protected Environment _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Environment_Points")]
    [Metadata("Describes a piece of data to be collected, including limits.  The user entering the data can dynamically add extra samples as well as dynamically adding new data points.", "DataPointCollectionPointChgs", false, false, false, "DataPointCollectionPointChgs", 1052429, false, true, false, null)]
    protected DataPointCollectionPointChgs_Environment _Points;
    [Metadata("A DataPointCollectionGroup contains a list of DataPointColletionPoint objects to be collected.  The data points may be related to each other, and presented in a vertical or horizontal format, or unrelated (Unassociated) and presented individually.", "DataPointCollectionGroupChgs", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("A DataPointCollectionGroup contains a list of DataPointColletionPoint objects to be collected.  The data points may be related to each other, and presented in a vertical or horizontal format, or unrelated (Unassociated) and presented individually.", "DataPointCollectionGroup", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Environment_Sequence")]
    protected Environment _Sequence;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052428, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Environment_MinimumSamples")]
    protected Environment _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052426, false, false, false, null)]
    protected new Environment _Name;

    public Environment GroupLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupLayout), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GroupLayout));
      }
    }

    public DataPointCollectionPointChgs_Environment Points
    {
      [param: In] set
      {
        this.PropertySet(nameof (Points), (object) value);
      }
      get
      {
        return (DataPointCollectionPointChgs_Environment) this.PropertyGet(nameof (Points));
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

    public Environment MinimumSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinimumSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinimumSamples));
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
