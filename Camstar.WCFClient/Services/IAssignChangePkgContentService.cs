// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAssignChangePkgContentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAssignChangePkgContentService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus GetCollaboratorEntry(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus GetNextSheetLevel(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus IsSheelLevelCompleted(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_LoadESigDetails_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus SendEmailMessages(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Parameters parameters,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AssignChangePkgContentMethod[] methods,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AssignChangePkgContent assignChangePkgContent,
      AssignChangePkgContent_Request request,
      out AssignChangePkgContent_Result result);
  }
}
