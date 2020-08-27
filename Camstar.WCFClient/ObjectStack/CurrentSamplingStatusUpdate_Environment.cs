// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentSamplingStatusUpdate_Environment
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
  public class CurrentSamplingStatusUpdate_Environment : GenericTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Environment_NewInspectionLevel")]
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, false, "NamedObjectRef", 16777730, false, false, true, null)]
    protected Environment _NewInspectionLevel;
    [Metadata("Used to track the current status of a products sampling plan", "SamplingCurrentStatus", false, false, false, "SamplingCurrentStatus", 1049843, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Environment_ServiceDetails")]
    protected SamplingCurrentStatus_Environment _ServiceDetails;
    [Metadata("Used to track the current status of a products sampling plan", "SamplingCurrentStatus", true, false, false, "SamplingCurrentStatus", 16777733, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Environment_SamplingCurrentStatus")]
    protected SamplingCurrentStatus_Environment _SamplingCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Environment_NewSampleRateCounterValue")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777731, false, false, false, null)]
    protected Environment _NewSampleRateCounterValue;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Environment_TrackableObject")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051446, false, false, false, null)]
    protected new Environment _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Environment_ResetInspectionLevel")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777732, false, false, false, "0")]
    protected Environment _ResetInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", true, true, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected Environment _Product;

    public Environment NewInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewInspectionLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewInspectionLevel));
      }
    }

    public SamplingCurrentStatus_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (SamplingCurrentStatus_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public SamplingCurrentStatus_Environment SamplingCurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingCurrentStatus), (object) value);
      }
      get
      {
        return (SamplingCurrentStatus_Environment) this.PropertyGet(nameof (SamplingCurrentStatus));
      }
    }

    public Environment NewSampleRateCounterValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewSampleRateCounterValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewSampleRateCounterValue));
      }
    }

    public new Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Environment ResetInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetInspectionLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResetInspectionLevel));
      }
    }

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }
  }
}
