// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChklstResponseDtl
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
  public class ExecuteChklstResponseDtl : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_ResponseItemDisplay")]
    protected Camstar.WCF.ObjectStack.ResponseItem _ResponseItemDisplay;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_ResponseItem")]
    protected SubentityRef _ResponseItem;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_ResponseSelected")]
    protected Primitive<bool> _ResponseSelected;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Response")]
    protected Primitive<string> _Response;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_ResponseValue")]
    protected Primitive<int> _ResponseValue;

    public override bool Equals(object obj)
    {
      return obj is ExecuteChklstResponseDtl && object.Equals((object) this._ResponseItemDisplay, (object) ((ExecuteChklstResponseDtl) obj)._ResponseItemDisplay) && (object.Equals((object) this._ResponseItem, (object) ((ExecuteChklstResponseDtl) obj)._ResponseItem) && object.Equals((object) this._ResponseSelected, (object) ((ExecuteChklstResponseDtl) obj)._ResponseSelected)) && (object.Equals((object) this._Response, (object) ((ExecuteChklstResponseDtl) obj)._Response) && object.Equals((object) this._ResponseValue, (object) ((ExecuteChklstResponseDtl) obj)._ResponseValue)) && base.Equals(obj);
    }

    public Camstar.WCF.ObjectStack.ResponseItem ResponseItemDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseItemDisplay), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ResponseItem) this.PropertyGet(nameof (ResponseItemDisplay));
      }
    }

    public SubentityRef ResponseItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseItem), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ResponseItem));
      }
    }

    public Primitive<bool> ResponseSelected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseSelected), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ResponseSelected));
      }
    }

    public Primitive<string> Response
    {
      [param: In] set
      {
        this.PropertySet(nameof (Response), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Response));
      }
    }

    public Primitive<int> ResponseValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseValue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ResponseValue));
      }
    }
  }
}
