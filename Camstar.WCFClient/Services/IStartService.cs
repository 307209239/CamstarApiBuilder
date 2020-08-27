// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IStartService
  {
    [OperationContract]
    ResultStatus AttachCarrier(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus ContainerTxn_Validations(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus GetTransactionWIPMsgs(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Start start,
      Start_LoadESigDetails_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus ProcessChildAutoNumber(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus ProcessOnlyChildAutoNumber(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus Sampling_StartSetupSampling(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus SetWFStack(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus ShopFloor_ApplyDetails(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus ValidateCarrier(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus ValidateResource(
      UserProfile userProfile,
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      StartMethod[] methods,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Start start,
      Start_Request request,
      out Start_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Start start,
      Start_Request request,
      out Start_Result result);
  }
}
