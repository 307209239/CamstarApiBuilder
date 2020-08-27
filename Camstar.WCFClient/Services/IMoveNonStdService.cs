// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMoveNonStdService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMoveNonStdService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_LoadESigDetails_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MoveNonStdMethod[] methods,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result);
  }
}
