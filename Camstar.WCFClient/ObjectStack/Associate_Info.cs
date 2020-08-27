// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Associate_Info
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
  public class Associate_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Associate_Info_EligibleContainersInquiry")]
    protected EligibleContainersInquiry_Info _EligibleContainersInquiry;
    [DataMember(EmitDefaultValue = false, Name = "Associate_Info_ChildContainers")]
    protected Info _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "Associate_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "Associate_Info_AssociatedContainers")]
    protected Info _AssociatedContainers;

    public EligibleContainersInquiry_Info EligibleContainersInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (EligibleContainersInquiry), (object) value);
      }
      get
      {
        return (EligibleContainersInquiry_Info) this.PropertyGet(nameof (EligibleContainersInquiry));
      }
    }

    public Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info AssociatedContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssociatedContainers));
      }
    }
  }
}
