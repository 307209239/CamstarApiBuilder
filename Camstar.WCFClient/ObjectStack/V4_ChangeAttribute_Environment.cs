// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_ChangeAttribute_Environment
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
  public class V4_ChangeAttribute_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_ChangeAttribute_Environment_ContainerStatusDetails")]
    [Metadata("The ChangeAttribute CDO is the parent for this subclass. All CVEs will resolve through the ChangeAttribute.Container field", "ChangeAttributeAsParent", false, false, false, "ChangeAttributeAsParent", 1049722, true, false, false, null)]
    protected ChangeAttributeAsParent_Environment _ContainerStatusDetails;
    [Metadata("Contains information on a container field that is to be updated. Base CDO for those field type specific detail CDOs with  new value for the container field.", "ChangeAttributeDetails", false, false, false, "ChangeAttributeDetails", 1049090, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_ChangeAttribute_Environment_ServiceDetails")]
    protected ChangeAttributeDetails_Environment _ServiceDetails;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049124, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_ChangeAttribute_Environment_IncludeChildren")]
    protected Environment _IncludeChildren;

    public ChangeAttributeAsParent_Environment ContainerStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatusDetails), (object) value);
      }
      get
      {
        return (ChangeAttributeAsParent_Environment) this.PropertyGet(nameof (ContainerStatusDetails));
      }
    }

    public ChangeAttributeDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ChangeAttributeDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}
