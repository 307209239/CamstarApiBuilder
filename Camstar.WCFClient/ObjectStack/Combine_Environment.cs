// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Combine_Environment
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
  public class Combine_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Combine_Environment_FromContainerDetails")]
    [Metadata("List of detail CDOs that contain information about where the materials to be transferred come from.", "CombineFromDetail", false, true, false, "CombineFromDetail", 1049661, false, true, false, null)]
    protected CombineFromDetail_Environment _FromContainerDetails;
    [DataMember(EmitDefaultValue = false, Name = "Combine_Environment_EligibleContainersInquiry")]
    [Metadata("The EligibleContainersInquiry service can be used to retrieve Containers based on a set of eligibility criteria (based on the particular type of service for which the Containers are being selected) and for a set of filtering criteria.", "EligibleContainersInquiry", false, false, false, "EligibleContainersInquiry", 1052664, true, false, false, null)]
    protected EligibleContainersInquiry_Environment _EligibleContainersInquiry;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049402, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Combine_Environment_CloseWhenEmpty")]
    protected Environment _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "Combine_Environment_CombineType")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052963, false, false, false, "0")]
    protected Environment _CombineType;
    [DataMember(EmitDefaultValue = false, Name = "Combine_Environment_AllowZeroQtys")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051471, false, false, false, "1")]
    protected Environment _AllowZeroQtys;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Combine_Environment_Container")]
    protected new Environment _Container;

    public CombineFromDetail_Environment FromContainerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainerDetails), (object) value);
      }
      get
      {
        return (CombineFromDetail_Environment) this.PropertyGet(nameof (FromContainerDetails));
      }
    }

    public EligibleContainersInquiry_Environment EligibleContainersInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (EligibleContainersInquiry), (object) value);
      }
      get
      {
        return (EligibleContainersInquiry_Environment) this.PropertyGet(nameof (EligibleContainersInquiry));
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

    public Environment CombineType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CombineType));
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

    public new Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }
  }
}
