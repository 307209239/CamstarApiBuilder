// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateSamplingLotService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateSamplingLotService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_LoadESigDetails_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateSamplingLotMethod[] methods,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result);
  }
}
