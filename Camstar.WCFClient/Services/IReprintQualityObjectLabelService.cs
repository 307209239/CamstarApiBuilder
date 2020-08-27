// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReprintQualityObjectLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReprintQualityObjectLabelService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_LoadESigDetails_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReprintQualityObjectLabelMethod[] methods,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result);
  }
}
