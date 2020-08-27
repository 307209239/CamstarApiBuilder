// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISerializeSecondaryQtyService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISerializeSecondaryQtyService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_LoadESigDetails_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SerializeSecondaryQtyMethod[] methods,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result);
  }
}
