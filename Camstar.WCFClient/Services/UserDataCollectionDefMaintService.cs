// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserDataCollectionDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UserDataCollectionDefMaintService : DataCollectionDefMaintBase
  {
    public UserDataCollectionDefMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUserDataCollectionDefMaintService), userProfile);
    }

    public ResultStatus Delete(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).Delete(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus Delete(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.Delete(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus Delete(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.Delete(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.DeleteAllRevisions(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.DeleteAllRevisions(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).Freeze(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus Freeze(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.Freeze(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus Freeze(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.Freeze(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).GetWIPMsgs(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.GetWIPMsgs(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.GetWIPMsgs(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).Load(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus Load(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.Load(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus Load(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.Load(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_LoadESigDetails_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).LoadESigDetails(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.LoadESigDetails, (UserDataCollectionDefMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_LoadESigDetails_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.LoadESigDetails(userDataCollectionDefMaint, (UserDataCollectionDefMaint_LoadESigDetails_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.LoadESigDetails(userDataCollectionDefMaint, (UserDataCollectionDefMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).New(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus New(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.New(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus New(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.New(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).NewCopy(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.NewCopy(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.NewCopy(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).NewRev(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus NewRev(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.NewRev(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus NewRev(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.NewRev(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).NewRevCopy(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.NewRevCopy(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.NewRevCopy(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).SaveAs(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.SaveAs(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.SaveAs(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).SaveAsRev(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.SaveAsRev(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.SaveAsRev(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).UnFreeze(this._UserProfile, userDataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(userDataCollectionDefMaint, UserDataCollectionDefMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) userDataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UserDataCollectionDefMaint) null, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserDataCollectionDefMaint userDataCollectionDefMaint)
    {
      return this.UnFreeze(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.UnFreeze(userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_LoadESigDetails_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.New((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.Load((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject userDataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserDataCollectionDefMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UserDataCollectionDefMaint) userDataCollectionDefMaint, (UserDataCollectionDefMaint_Parameters) parameters, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      try
      {
        UserDataCollectionDefMaintMethod[] methods = new UserDataCollectionDefMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUserDataCollectionDefMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserDataCollectionDefMaint cdo,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      try
      {
        return ((IUserDataCollectionDefMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UserDataCollectionDefMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UserDataCollectionDefMaint) cdo, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.GetEnvironment((UserDataCollectionDefMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UserDataCollectionDefMaint cdo,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      result = (UserDataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserDataCollectionDefMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(cdo, UserDataCollectionDefMaintMethods.ExecuteTransaction, (UserDataCollectionDefMaint_Parameters) null));
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
        UserDataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UserDataCollectionDefMaint) cdo, (UserDataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UserDataCollectionDefMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UserDataCollectionDefMaint_Request) null, out UserDataCollectionDefMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result)
    {
      return this.ExecuteTransaction((UserDataCollectionDefMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UserDataCollectionDefMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UserDataCollectionDefMaintMethod(cdo, UserDataCollectionDefMaintMethods.AddDataTransaction, (UserDataCollectionDefMaint_Parameters) null));
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
        return this.AddDataTransaction((UserDataCollectionDefMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
