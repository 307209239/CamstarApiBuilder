// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPrintQualityObjectLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPrintQualityObjectLabelService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_LoadESigDetails_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PrintQualityObjectLabelMethod[] methods,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result);
  }
}
