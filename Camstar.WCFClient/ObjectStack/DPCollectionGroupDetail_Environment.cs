// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionGroupDetail_Environment
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
  public class DPCollectionGroupDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("Enumeration for the Data Point Collection Group Layout:\r\n1 = Vertical\r\n2 = Horizontal\r\n3 = Unassociated", "DPCollectionGroupLayoutEnum", false, false, false, "Integer", 1052404, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Environment_GroupLayout")]
    protected Environment _GroupLayout;
    [Metadata("A DataPointCollectionGroup contains a list of DataPointColletionPoint objects to be collected.  The data points may be related to each other, and presented in a vertical or horizontal format, or unrelated (Unassociated) and presented individually.", "DataPointCollectionGroup", false, false, false, "NamedSubentityRef", 1052462, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Environment_Group")]
    protected Environment _Group;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Environment_ServiceDetails")]
    [Metadata("The DPCollectionPointDetail is used to collect samples for a Point within a DataPointCollectionDef.", "DPCollectionPointDetail", false, false, false, "DPCollectionPointDetail", 1052429, false, true, false, null)]
    protected DPCollectionPointDetail_Environment _ServiceDetails;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052484, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Environment_LastEnteredOnGMT")]
    protected Environment _LastEnteredOnGMT;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052428, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Environment_MinimumSamples")]
    protected Environment _MinimumSamples;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052482, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Environment_LastEnteredByRole")]
    protected Environment _LastEnteredByRole;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052481, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Environment_LastEnteredBy")]
    protected Environment _LastEnteredBy;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupDetail_Environment_Name")]
    protected Environment _Name;

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

    public DPCollectionPointDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DPCollectionPointDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment LastEnteredOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEnteredOnGMT));
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

    public Environment LastEnteredByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredByRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEnteredByRole));
      }
    }

    public Environment LastEnteredBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEnteredBy));
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
