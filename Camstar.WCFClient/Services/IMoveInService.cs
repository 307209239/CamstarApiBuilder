// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMoveInService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMoveInService
  {
    [OperationContract]
    ResultStatus AssignCellContainerClearance(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_AssignCellContainerClearance_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus AssignCellMfgOrderClearance(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_LoadESigDetails_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus RejectNonconformingMtl(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus ValidateCellContainerClearance(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_ValidateCellContainerClearance_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus ValidateCellMfgOrderClearance(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus ValidateQueueTime(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Parameters parameters,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MoveInMethod[] methods,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MoveIn moveIn,
      MoveIn_Request request,
      out MoveIn_Result result);
  }
}
