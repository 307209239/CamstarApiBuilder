// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRCloseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRCloseService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus GetAttributes(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_LoadESigDetails_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus TerminateContainerCrossRefs(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRCloseMethod[] methods,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result);
  }
}
