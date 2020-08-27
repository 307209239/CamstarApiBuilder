// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMoveStdService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMoveStdService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_LoadESigDetails_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus MoveStd_LotSamplingValidations(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus Sampling_MoveValidations(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus SamplingValidation(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus ValidateEProcedure(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus ValidateTaskComplete(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_ValidateTaskComplete_Parameters parameters,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MoveStdMethod[] methods,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MoveStd moveStd,
      MoveStd_Request request,
      out MoveStd_Result result);
  }
}
