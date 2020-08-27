// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChklstResponseDtl_Environment
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
  public class ExecuteChklstResponseDtl_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Environment_ResponseItemDisplay")]
    [Metadata("Defines the response entry within Response Set.", "ResponseItem", false, false, true, "ResponseItem", 1052425, false, false, false, null)]
    protected ResponseItem_Environment _ResponseItemDisplay;
    [Metadata("Defines the response entry within Response Set.", "ResponseItem", false, false, false, "SubentityRef", 1052433, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Environment_ResponseItem")]
    protected Environment _ResponseItem;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Environment_ResponseSelected")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052434, false, false, false, "0")]
    protected Environment _ResponseSelected;
    [Metadata("Generic String", "", false, false, true, "String", 1051732, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Environment_Response")]
    protected Environment _Response;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052423, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseDtl_Environment_ResponseValue")]
    protected Environment _ResponseValue;

    public ResponseItem_Environment ResponseItemDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseItemDisplay), (object) value);
      }
      get
      {
        return (ResponseItem_Environment) this.PropertyGet(nameof (ResponseItemDisplay));
      }
    }

    public Environment ResponseItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseItem));
      }
    }

    public Environment ResponseSelected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseSelected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseSelected));
      }
    }

    public Environment Response
    {
      [param: In] set
      {
        this.PropertySet(nameof (Response), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Response));
      }
    }

    public Environment ResponseValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseValue));
      }
    }
  }
}
