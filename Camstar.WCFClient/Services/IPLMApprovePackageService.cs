// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPLMApprovePackageService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPLMApprovePackageService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_LoadESigDetails_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PLMApprovePackageMethod[] methods,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result);
  }
}
