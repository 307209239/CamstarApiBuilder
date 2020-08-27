// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceSetup_Info
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
  public class ResourceSetup_Info : ResourceTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_ResourceStatusDetails")]
    protected new ResourceStatusDetails_Info _ResourceStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_ResourceStatusHistory")]
    protected ResourceStatusHistory_Info _ResourceStatusHistory;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_ResourceState")]
    protected Info _ResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_Run")]
    protected Info _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_UpdateLastStatusChangeDate")]
    protected Info _UpdateLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_Setup")]
    protected Info _Setup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_Availability")]
    protected Info _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_ResourceStatusReason")]
    protected Info _ResourceStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_Resource")]
    protected new Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Info_ResourceStatusCode")]
    protected Info _ResourceStatusCode;

    public new ResourceStatusDetails_Info ResourceStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusDetails), (object) value);
      }
      get
      {
        return (ResourceStatusDetails_Info) this.PropertyGet(nameof (ResourceStatusDetails));
      }
    }

    public Info ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public ResourceStatusHistory_Info ResourceStatusHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusHistory), (object) value);
      }
      get
      {
        return (ResourceStatusHistory_Info) this.PropertyGet(nameof (ResourceStatusHistory));
      }
    }

    public Info ResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceState), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceState));
      }
    }

    public Info Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Run));
      }
    }

    public Info UpdateLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UpdateLastStatusChangeDate));
      }
    }

    public Info Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Setup));
      }
    }

    public Info Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Availability));
      }
    }

    public Info ResourceStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusReason));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public new Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }
  }
}
