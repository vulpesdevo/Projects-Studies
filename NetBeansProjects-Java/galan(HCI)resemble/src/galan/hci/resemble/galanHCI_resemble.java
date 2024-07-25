package galan.hci.resemble;

import javax.swing.JOptionPane;

public class galanHCI_resemble extends javax.swing.JFrame {

    public galanHCI_resemble() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        processGalan = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        jLabel9 = new javax.swing.JLabel();
        APgalan = new javax.swing.JTextField();
        Akggalan = new javax.swing.JTextField();
        a10galan = new javax.swing.JTextField();
        BAgalan = new javax.swing.JTextField();
        Bkggalan = new javax.swing.JTextField();
        b10galan = new javax.swing.JTextField();
        MAgalan = new javax.swing.JTextField();
        Mkggalan = new javax.swing.JTextField();
        m10galan = new javax.swing.JTextField();
        disAgalan = new javax.swing.JLabel();
        disBgalan = new javax.swing.JLabel();
        disMgalan = new javax.swing.JLabel();
        jLabel16 = new javax.swing.JLabel();
        cashgalan = new javax.swing.JTextField();
        jLabel18 = new javax.swing.JLabel();
        idgalan = new javax.swing.JTextField();
        taxgalan = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        valgalan = new javax.swing.JLabel();
        Billgalan = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        processGalan.setText("PROCESS");
        processGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                processGalanActionPerformed(evt);
            }
        });

        jLabel1.setText("Apple QTY : ");
        jLabel1.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel2.setText("KG : ");
        jLabel2.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel3.setText("10 KG : ");
        jLabel3.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel4.setText("Banana QTY : ");
        jLabel4.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel5.setText("KG : ");
        jLabel5.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel6.setText("10 KG : ");
        jLabel6.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel7.setText("Mango QTY : ");
        jLabel7.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel8.setText("KG : ");
        jLabel8.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel9.setText("10 KG : ");
        jLabel9.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        disAgalan.setFont(new java.awt.Font("sansserif", 1, 12)); // NOI18N
        disAgalan.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        disBgalan.setFont(new java.awt.Font("sansserif", 1, 12)); // NOI18N
        disBgalan.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        disMgalan.setFont(new java.awt.Font("sansserif", 1, 12)); // NOI18N
        disMgalan.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        jLabel16.setText("Enter Cash : ");
        jLabel16.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel18.setText("Do you have Senior ID : ");
        jLabel18.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        taxgalan.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        taxgalan.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        jLabel11.setText("Bill : ");

        jLabel10.setText("jLabel10");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(67, 67, 67)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(processGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel8)
                        .addGap(18, 18, 18)
                        .addComponent(Mkggalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel7)
                        .addGap(18, 18, 18)
                        .addComponent(MAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel6)
                        .addGap(18, 18, 18)
                        .addComponent(b10galan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel5)
                        .addGap(18, 18, 18)
                        .addComponent(Bkggalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel4)
                        .addGap(18, 18, 18)
                        .addComponent(BAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel3)
                        .addGap(18, 18, 18)
                        .addComponent(a10galan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel2)
                        .addGap(18, 18, 18)
                        .addComponent(Akggalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addGap(18, 18, 18)
                        .addComponent(APgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel9)
                        .addGap(18, 18, 18)
                        .addComponent(m10galan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel18)
                        .addGap(18, 18, 18)
                        .addComponent(idgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel11)
                            .addComponent(jLabel16))
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(18, 18, 18)
                                .addComponent(Billgalan, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(28, 28, 28)
                                .addComponent(cashgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(disBgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 110, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(disMgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 110, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(disAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 110, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(taxgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(valgalan, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel10, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 0, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(37, 37, 37))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(32, 32, 32)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(APgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel2)
                            .addComponent(Akggalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel3)
                            .addComponent(a10galan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addComponent(disAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(26, 26, 26)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(BAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel5)
                            .addComponent(Bkggalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel6)
                            .addComponent(b10galan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addComponent(disBgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(26, 26, 26)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(MAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel7))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel8)
                            .addComponent(Mkggalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel9)
                            .addComponent(m10galan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addComponent(disMgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(23, 23, 23)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel11)
                    .addComponent(taxgalan, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 20, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(Billgalan, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addGap(17, 17, 17)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(valgalan, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 20, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel16)
                        .addComponent(cashgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel18)
                    .addComponent(idgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(32, 32, 32)
                        .addComponent(processGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addComponent(jLabel10)))
                .addGap(52, 52, 52))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void processGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_processGalanActionPerformed
        double applegalan, bananagalan, mangogalan,
                Apkggalan, Bakggalan, Makggalan,
                Atengalan, Btengalan, Mtengalan,
                agalan, bgalan, mgalan,
                chGalan,
                BILLgalan, Tgalan, Cash_galan;

        String seniorgalan;

        applegalan = Double.parseDouble(APgalan.getText());
        bananagalan = Double.parseDouble(BAgalan.getText());
        mangogalan = Double.parseDouble(MAgalan.getText());

        Apkggalan = Double.parseDouble(Akggalan.getText());
        Bakggalan = Double.parseDouble(Bkggalan.getText());
        Makggalan = Double.parseDouble(Mkggalan.getText());

        Atengalan = Double.parseDouble(a10galan.getText());
        Btengalan = Double.parseDouble(b10galan.getText());
        Mtengalan = Double.parseDouble(m10galan.getText());

        Cash_galan = Double.parseDouble(cashgalan.getText());
        seniorgalan = idgalan.getText();

        applegalan *= 20;//
        Apkggalan *= 55;//
        Atengalan *= 55;
        agalan = Atengalan * .10;
        Atengalan -= agalan; //
        disAgalan.setText(Double.toString(Atengalan));
        bananagalan *= 10;//
        Bakggalan *= 80;//
        Btengalan *= 80;
        bgalan = Btengalan * .10;
        Btengalan -= bgalan;//
        disBgalan.setText(Double.toString(Btengalan));

        mangogalan *= 18;//
        Makggalan *= 90;//
        Mtengalan *= 90;
        mgalan = Mtengalan * .10;
        Mtengalan -= mgalan;//
        disMgalan.setText(Double.toString(Mtengalan));

        BILLgalan = applegalan + Apkggalan + Atengalan
                + bananagalan + Bakggalan + Btengalan
                + mangogalan + Makggalan + Mtengalan;
        Tgalan = BILLgalan * .12;
        Billgalan.setText(Double.toString(BILLgalan));
        taxgalan.setText("\nTAX : " + Tgalan);
        if (Cash_galan >= BILLgalan) {
            valgalan.setText("Sufficient");
            if (seniorgalan.equalsIgnoreCase("yes")) {
                double subGalan = BILLgalan * .20;
                BILLgalan -= subGalan;
                chGalan = Cash_galan - BILLgalan;
                JOptionPane.showMessageDialog(null, "\nDiscounted Bill (20%) :  " + BILLgalan
                        + "\nChange :  " + chGalan);
            } else {
                chGalan = Cash_galan - BILLgalan;
                JOptionPane.showMessageDialog(null, "Total Bill :  " + BILLgalan
                        + "\nChange :  " + chGalan);
            }
        } else {
            valgalan.setText("Insufficient");
            JOptionPane.showMessageDialog(null, "Insufficient cash !");
        }
    }//GEN-LAST:event_processGalanActionPerformed

    public static void main(String Galan[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new galanHCI_resemble().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextField APgalan;
    private javax.swing.JTextField Akggalan;
    private javax.swing.JTextField BAgalan;
    private javax.swing.JLabel Billgalan;
    private javax.swing.JTextField Bkggalan;
    private javax.swing.JTextField MAgalan;
    private javax.swing.JTextField Mkggalan;
    private javax.swing.JTextField a10galan;
    private javax.swing.JTextField b10galan;
    private javax.swing.JTextField cashgalan;
    private javax.swing.JLabel disAgalan;
    private javax.swing.JLabel disBgalan;
    private javax.swing.JLabel disMgalan;
    private javax.swing.JTextField idgalan;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel16;
    private javax.swing.JLabel jLabel18;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JTextField m10galan;
    private javax.swing.JButton processGalan;
    private javax.swing.JLabel taxgalan;
    private javax.swing.JLabel valgalan;
    // End of variables declaration//GEN-END:variables
}
