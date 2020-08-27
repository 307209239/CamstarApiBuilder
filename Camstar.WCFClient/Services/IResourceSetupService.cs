// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceSetupService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceSetupService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_LoadESigDetails_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus SetLastStatusChangeDate(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Parameters parameters,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceSetupMethod[] methods,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceSetup resourceSetup,
      ResourceSetup_Request request,
      out ResourceSetup_Result result);
  }
}
