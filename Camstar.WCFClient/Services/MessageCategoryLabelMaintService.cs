// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MessageCategoryLabelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MessageCategoryLabelMaintService : UserLabelMaintBase
  {
    public MessageCategoryLabelMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMessageCategoryLabelMaintService), userProfile);
    }

    public ResultStatus Delete(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).Delete(this._UserProfile, messageCategoryLabelMaint, parameters, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(messageCategoryLabelMaint, MessageCategoryLabelMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MessageCategoryLabelMaint) null, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus Delete(
      MessageCategoryLabelMaint messageCategoryLabelMaint)
    {
      return this.Delete(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus Delete(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.Delete(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).Freeze(this._UserProfile, messageCategoryLabelMaint, parameters, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(messageCategoryLabelMaint, MessageCategoryLabelMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MessageCategoryLabelMaint) null, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus Freeze(
      MessageCategoryLabelMaint messageCategoryLabelMaint)
    {
      return this.Freeze(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus Freeze(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.Freeze(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).GetWIPMsgs(this._UserProfile, messageCategoryLabelMaint, parameters, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(messageCategoryLabelMaint, MessageCategoryLabelMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MessageCategoryLabelMaint) null, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MessageCategoryLabelMaint messageCategoryLabelMaint)
    {
      return this.GetWIPMsgs(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.GetWIPMsgs(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).Load(this._UserProfile, messageCategoryLabelMaint, parameters, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(messageCategoryLabelMaint, MessageCategoryLabelMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MessageCategoryLabelMaint) null, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus Load(
      MessageCategoryLabelMaint messageCategoryLabelMaint)
    {
      return this.Load(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus Load(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.Load(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_LoadESigDetails_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).LoadESigDetails(this._UserProfile, messageCategoryLabelMaint, parameters, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(messageCategoryLabelMaint, MessageCategoryLabelMaintMethods.LoadESigDetails, (MessageCategoryLabelMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MessageCategoryLabelMaint) null, (MessageCategoryLabelMaint_LoadESigDetails_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MessageCategoryLabelMaint messageCategoryLabelMaint)
    {
      return this.LoadESigDetails(messageCategoryLabelMaint, (MessageCategoryLabelMaint_LoadESigDetails_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.LoadESigDetails(messageCategoryLabelMaint, (MessageCategoryLabelMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).New(this._UserProfile, messageCategoryLabelMaint, parameters, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(messageCategoryLabelMaint, MessageCategoryLabelMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MessageCategoryLabelMaint) null, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus New(
      MessageCategoryLabelMaint messageCategoryLabelMaint)
    {
      return this.New(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus New(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.New(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).NewCopy(this._UserProfile, messageCategoryLabelMaint, parameters, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(messageCategoryLabelMaint, MessageCategoryLabelMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MessageCategoryLabelMaint) null, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus NewCopy(
      MessageCategoryLabelMaint messageCategoryLabelMaint)
    {
      return this.NewCopy(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus NewCopy(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.NewCopy(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).SaveAs(this._UserProfile, messageCategoryLabelMaint, parameters, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(messageCategoryLabelMaint, MessageCategoryLabelMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MessageCategoryLabelMaint) null, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus SaveAs(
      MessageCategoryLabelMaint messageCategoryLabelMaint)
    {
      return this.SaveAs(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus SaveAs(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.SaveAs(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Parameters parameters,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).UnFreeze(this._UserProfile, messageCategoryLabelMaint, parameters, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(messageCategoryLabelMaint, MessageCategoryLabelMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) messageCategoryLabelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MessageCategoryLabelMaint) null, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MessageCategoryLabelMaint messageCategoryLabelMaint)
    {
      return this.UnFreeze(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MessageCategoryLabelMaint messageCategoryLabelMaint,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.UnFreeze(messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject messageCategoryLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MessageCategoryLabelMaint) messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) parameters, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject messageCategoryLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MessageCategoryLabelMaint) messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) parameters, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject messageCategoryLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MessageCategoryLabelMaint) messageCategoryLabelMaint, (MessageCategoryLabelMaint_LoadESigDetails_Parameters) parameters, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject messageCategoryLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.New((MessageCategoryLabelMaint) messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) parameters, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject messageCategoryLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MessageCategoryLabelMaint) messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) parameters, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject messageCategoryLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MessageCategoryLabelMaint) messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) parameters, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject messageCategoryLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MessageCategoryLabelMaint) messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) parameters, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject messageCategoryLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.Load((MessageCategoryLabelMaint) messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) parameters, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject messageCategoryLabelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MessageCategoryLabelMaint) messageCategoryLabelMaint, (MessageCategoryLabelMaint_Parameters) parameters, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      try
      {
        MessageCategoryLabelMaintMethod[] methods = new MessageCategoryLabelMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMessageCategoryLabelMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MessageCategoryLabelMaint cdo,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      try
      {
        return ((IMessageCategoryLabelMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MessageCategoryLabelMaint) cdo, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.GetEnvironment((MessageCategoryLabelMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MessageCategoryLabelMaint cdo,
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      result = (MessageCategoryLabelMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMessageCategoryLabelMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(cdo, MessageCategoryLabelMaintMethods.ExecuteTransaction, (MessageCategoryLabelMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MessageCategoryLabelMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MessageCategoryLabelMaint) cdo, (MessageCategoryLabelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MessageCategoryLabelMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MessageCategoryLabelMaint_Request) null, out MessageCategoryLabelMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MessageCategoryLabelMaint_Request request,
      out MessageCategoryLabelMaint_Result result)
    {
      return this.ExecuteTransaction((MessageCategoryLabelMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MessageCategoryLabelMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MessageCategoryLabelMaintMethod(cdo, MessageCategoryLabelMaintMethods.AddDataTransaction, (MessageCategoryLabelMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((MessageCategoryLabelMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
