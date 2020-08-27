// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusDetails_Info
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
  public class ResourceStatusDetails_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_Availability")]
    protected Info _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_ResourceAvailability")]
    protected Info _ResourceAvailability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_ProductRev")]
    protected Info _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_ReasonCodeName")]
    protected Info _ReasonCodeName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_TimeAtStatus")]
    protected Info _TimeAtStatus;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_SetupRev")]
    protected Info _SetupRev;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_StatusCodeName")]
    protected Info _StatusCodeName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_Reason")]
    protected Info _Reason;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_Run")]
    protected Info _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_Setup")]
    protected Info _Setup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Info_SetupName")]
    protected Info _SetupName;

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

    public Info ResourceAvailability
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceAvailability), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceAvailability));
      }
    }

    public Info ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Info ReasonCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCodeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReasonCodeName));
      }
    }

    public Info ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductName));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info TimeAtStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimeAtStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimeAtStatus));
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

    public Info SetupRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SetupRev));
      }
    }

    public Info StatusCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusCodeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusCodeName));
      }
    }

    public Info Reason
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Reason));
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

    public Info SetupName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SetupName));
      }
    }
  }
}
