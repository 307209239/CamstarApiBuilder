// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChklstResponseDtl_Info
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
  public class ExecuteChklstResponseDtl_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Info_ResponseItemDisplay")]
    protected ResponseItem_Info _ResponseItemDisplay;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Info_ResponseItem")]
    protected Info _ResponseItem;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Info_ResponseSelected")]
    protected Info _ResponseSelected;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Info_Response")]
    protected Info _Response;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Info_ResponseValue")]
    protected Info _ResponseValue;

    public ResponseItem_Info ResponseItemDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseItemDisplay), (object) value);
      }
      get
      {
        return (ResponseItem_Info) this.PropertyGet(nameof (ResponseItemDisplay));
      }
    }

    public Info ResponseItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseItem));
      }
    }

    public Info ResponseSelected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseSelected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseSelected));
      }
    }

    public Info Response
    {
      [param: In] set
      {
        this.PropertySet(nameof (Response), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Response));
      }
    }

    public Info ResponseValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseValue));
      }
    }
  }
}
