// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRCloseQualityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRCloseQualityService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus GetAttributes(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_LoadESigDetails_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRCloseQualityMethod[] methods,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result);
  }
}
