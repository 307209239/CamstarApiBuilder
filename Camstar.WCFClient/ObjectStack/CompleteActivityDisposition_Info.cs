// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityDisposition_Info
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
  public class CompleteActivityDisposition_Info : CompleteActivity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Info_ServiceDetails")]
    protected DispositionDetail_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Info_ProcessObject")]
    protected new Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Info_Activity")]
    protected new Info _Activity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Info_Disposition")]
    protected Info _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Info_ProcessObjectDetails")]
    protected ActivityDisposition_Info _ProcessObjectDetails;

    public DispositionDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DispositionDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public new Info Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Activity));
      }
    }

    public Info Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Disposition));
      }
    }

    public ActivityDisposition_Info ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ActivityDisposition_Info) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }
  }
}
