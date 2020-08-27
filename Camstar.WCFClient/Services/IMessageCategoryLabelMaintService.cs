// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMessageCategoryLabelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMessageCategoryLabelMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_LoadESigDetails_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MessageCategoryLabelMaintMethod[] methods,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result);
  }
}
