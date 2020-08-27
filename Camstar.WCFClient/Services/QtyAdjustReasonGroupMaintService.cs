// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.QtyAdjustReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class QtyAdjustReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public QtyAdjustReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IQtyAdjustReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).Delete(this._UserProfile, qtyAdjustReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(qtyAdjustReasonGroupMaint, QtyAdjustReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((QtyAdjustReasonGroupMaint) null, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint)
    {
      return this.Delete(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.Delete(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, qtyAdjustReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(qtyAdjustReasonGroupMaint, QtyAdjustReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((QtyAdjustReasonGroupMaint) null, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint)
    {
      return this.Freeze(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.Freeze(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, qtyAdjustReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(qtyAdjustReasonGroupMaint, QtyAdjustReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((QtyAdjustReasonGroupMaint) null, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint)
    {
      return this.GetWIPMsgs(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).Load(this._UserProfile, qtyAdjustReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(qtyAdjustReasonGroupMaint, QtyAdjustReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((QtyAdjustReasonGroupMaint) null, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint)
    {
      return this.Load(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.Load(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_LoadESigDetails_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, qtyAdjustReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(qtyAdjustReasonGroupMaint, QtyAdjustReasonGroupMaintMethods.LoadESigDetails, (QtyAdjustReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((QtyAdjustReasonGroupMaint) null, (QtyAdjustReasonGroupMaint_LoadESigDetails_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint)
    {
      return this.LoadESigDetails(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_LoadESigDetails_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).New(this._UserProfile, qtyAdjustReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(qtyAdjustReasonGroupMaint, QtyAdjustReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((QtyAdjustReasonGroupMaint) null, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint)
    {
      return this.New(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.New(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, qtyAdjustReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(qtyAdjustReasonGroupMaint, QtyAdjustReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((QtyAdjustReasonGroupMaint) null, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint)
    {
      return this.NewCopy(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.NewCopy(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, qtyAdjustReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(qtyAdjustReasonGroupMaint, QtyAdjustReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((QtyAdjustReasonGroupMaint) null, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint)
    {
      return this.SaveAs(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.SaveAs(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, qtyAdjustReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(qtyAdjustReasonGroupMaint, QtyAdjustReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) qtyAdjustReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((QtyAdjustReasonGroupMaint) null, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint)
    {
      return this.UnFreeze(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.UnFreeze(qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject qtyAdjustReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((QtyAdjustReasonGroupMaint) qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) parameters, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject qtyAdjustReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((QtyAdjustReasonGroupMaint) qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) parameters, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject qtyAdjustReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((QtyAdjustReasonGroupMaint) qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_LoadESigDetails_Parameters) parameters, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject qtyAdjustReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((QtyAdjustReasonGroupMaint) qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) parameters, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject qtyAdjustReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((QtyAdjustReasonGroupMaint) qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) parameters, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject qtyAdjustReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((QtyAdjustReasonGroupMaint) qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) parameters, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject qtyAdjustReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((QtyAdjustReasonGroupMaint) qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) parameters, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject qtyAdjustReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((QtyAdjustReasonGroupMaint) qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) parameters, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject qtyAdjustReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((QtyAdjustReasonGroupMaint) qtyAdjustReasonGroupMaint, (QtyAdjustReasonGroupMaint_Parameters) parameters, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      try
      {
        QtyAdjustReasonGroupMaintMethod[] methods = new QtyAdjustReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IQtyAdjustReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QtyAdjustReasonGroupMaint cdo,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      try
      {
        return ((IQtyAdjustReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((QtyAdjustReasonGroupMaint) cdo, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((QtyAdjustReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      QtyAdjustReasonGroupMaint cdo,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      result = (QtyAdjustReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(cdo, QtyAdjustReasonGroupMaintMethods.ExecuteTransaction, (QtyAdjustReasonGroupMaint_Parameters) null));
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
        QtyAdjustReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((QtyAdjustReasonGroupMaint) cdo, (QtyAdjustReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(QtyAdjustReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (QtyAdjustReasonGroupMaint_Request) null, out QtyAdjustReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((QtyAdjustReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(QtyAdjustReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new QtyAdjustReasonGroupMaintMethod(cdo, QtyAdjustReasonGroupMaintMethods.AddDataTransaction, (QtyAdjustReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((QtyAdjustReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
