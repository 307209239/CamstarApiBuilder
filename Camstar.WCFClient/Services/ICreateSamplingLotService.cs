// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICreateSamplingLotService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICreateSamplingLotService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_LoadESigDetails_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CreateSamplingLotMethod[] methods,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result);
  }
}
