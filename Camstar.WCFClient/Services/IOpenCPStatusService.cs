// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOpenCPStatusService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOpenCPStatusService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_LoadESigDetails_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_Parameters parameters,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OpenCPStatusMethod[] methods,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      OpenCPStatus openCPStatus,
      OpenCPStatus_Request request,
      out OpenCPStatus_Result result);
  }
}
