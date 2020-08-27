// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAssignSingleCPContentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAssignSingleCPContentService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_LoadESigDetails_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AssignSingleCPContentMethod[] methods,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result);
  }
}
