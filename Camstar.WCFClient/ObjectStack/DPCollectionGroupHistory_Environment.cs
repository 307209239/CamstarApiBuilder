// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionGroupHistory_Environment
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
  public class DPCollectionGroupHistory_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Environment_GroupLayout")]
    [Metadata("Enumeration for the Data Point Collection Group Layout:\r\n1 = Vertical\r\n2 = Horizontal\r\n3 = Unassociated", "DPCollectionGroupLayoutEnum", false, false, true, "Integer", 1052404, false, false, false, null)]
    protected Environment _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Environment_HistoryDetails")]
    [Metadata("The history contains data points with samples (data point values).", "DPCollectionPointHistory", false, false, true, "SubentityRef", 1052466, false, true, false, null)]
    protected Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Environment_Group")]
    [Metadata("A DataPointCollectionGroup contains a list of DataPointColletionPoint objects to be collected.  The data points may be related to each other, and presented in a vertical or horizontal format, or unrelated (Unassociated) and presented individually.", "DataPointCollectionGroup", false, false, true, "NamedSubentityRef", 1052462, false, false, false, null)]
    protected Environment _Group;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Environment_MinimumSamples")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052428, false, false, false, null)]
    protected Environment _MinimumSamples;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Environment_Name")]
    protected Environment _Name;

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

    public Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment Group
    {
      [param: In] set
      {
        this.PropertySet(nameof (Group), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Group));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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

    public Environment Name
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
