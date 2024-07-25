package galan.oop.resemble;

import javax.swing.JOptionPane;

public class galanOOP_resemble extends javax.swing.JFrame {

    public galanOOP_resemble() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel16galan = new javax.swing.JLabel();
        cashgalan = new javax.swing.JTextField();
        jLabel7galan = new javax.swing.JLabel();
        jLabel18galan = new javax.swing.JLabel();
        jLabel8galan = new javax.swing.JLabel();
        idgalan = new javax.swing.JTextField();
        APgalan = new javax.swing.JTextField();
        Akggalan = new javax.swing.JTextField();
        BAgalan = new javax.swing.JTextField();
        Bkggalan = new javax.swing.JTextField();
        MAgalan = new javax.swing.JTextField();
        processGalan = new javax.swing.JButton();
        jLabel1galan = new javax.swing.JLabel();
        jLabel2galan = new javax.swing.JLabel();
        jLabel4galan = new javax.swing.JLabel();
        jLabel5galan = new javax.swing.JLabel();
        Mkggalan = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        Billgalan = new javax.swing.JLabel();
        valgalan = new javax.swing.JLabel();
        taxgalan = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel16galan.setText("Enter Cash : ");
        jLabel16galan.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel7galan.setText("Mango QTY : ");
        jLabel7galan.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel18galan.setText("Do you have Senior ID : ");
        jLabel18galan.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel8galan.setText("KG : ");
        jLabel8galan.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        processGalan.setText("PROCESS");
        processGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                processGalanActionPerformed(evt);
            }
        });

        jLabel1galan.setText("Apple QTY : ");
        jLabel1galan.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel2galan.setText("KG : ");
        jLabel2galan.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel4galan.setText("Banana QTY : ");
        jLabel4galan.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel5galan.setText("KG : ");
        jLabel5galan.setHorizontalTextPosition(javax.swing.SwingConstants.LEADING);

        jLabel1.setText("BILL : ");

        Billgalan.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N

        valgalan.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N

        taxgalan.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel8galan)
                        .addGap(18, 18, 18)
                        .addComponent(Mkggalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel7galan)
                        .addGap(18, 18, 18)
                        .addComponent(MAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel5galan)
                        .addGap(18, 18, 18)
                        .addComponent(Bkggalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel4galan)
                        .addGap(18, 18, 18)
                        .addComponent(BAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel2galan)
                        .addGap(18, 18, 18)
                        .addComponent(Akggalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1galan)
                        .addGap(18, 18, 18)
                        .addComponent(APgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel18galan)
                        .addGap(18, 18, 18)
                        .addComponent(idgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel1)
                            .addComponent(jLabel16galan))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(cashgalan, javax.swing.GroupLayout.DEFAULT_SIZE, 90, Short.MAX_VALUE)
                            .addComponent(Billgalan, javax.swing.GroupLayout.DEFAULT_SIZE, 90, Short.MAX_VALUE))))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(valgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(taxgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(61, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(processGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(154, 154, 154))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1galan)
                    .addComponent(APgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2galan)
                    .addComponent(Akggalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(30, 30, 30)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4galan)
                    .addComponent(BAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5galan)
                    .addComponent(Bkggalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(30, 30, 30)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(MAgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel7galan))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel8galan)
                    .addComponent(Mkggalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(7, 7, 7)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(Billgalan, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(taxgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel16galan)
                    .addComponent(cashgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(valgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel18galan)
                    .addComponent(idgalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(31, 31, 31)
                .addComponent(processGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(28, 28, 28))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void processGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_processGalanActionPerformed
        double applegalan, bananagalan, mangogalan,
                Apkggalan, Bakggalan, Makggalan,
                chGalan,
                BILLgalan, Tgalan, Cash_galan;

        String seniorgalan;

        applegalan = Double.parseDouble(APgalan.getText());
        bananagalan = Double.parseDouble(BAgalan.getText());
        mangogalan = Double.parseDouble(MAgalan.getText());

        Apkggalan = Double.parseDouble(Akggalan.getText());
        Bakggalan = Double.parseDouble(Bkggalan.getText());
        Makggalan = Double.parseDouble(Mkggalan.getText());

        Cash_galan = Double.parseDouble(cashgalan.getText());
        seniorgalan = idgalan.getText();

        applegalan *= 20;//
        Apkggalan *= 55;//

        bananagalan *= 10;//
        Bakggalan *= 80;//

        mangogalan *= 18;//
        Makggalan *= 90;//

        BILLgalan = applegalan + Apkggalan
                + bananagalan + Bakggalan
                + mangogalan + Makggalan;
        Tgalan = BILLgalan * .12;
        Billgalan.setText(Double.toString(BILLgalan));
        taxgalan.setText("\nTAX : " + Tgalan);
        if (Cash_galan >= BILLgalan) {
            valgalan.setText("Valid");
            if (seniorgalan.equalsIgnoreCase("yes")) {

                double subGalan = BILLgalan * .20;
                BILLgalan -= subGalan;
                chGalan = Cash_galan - BILLgalan;
                JOptionPane.showMessageDialog(null, "\nDiscounted Bill(20%) :  " + BILLgalan
                        + "\nChange :  " + chGalan);
            } else {
                chGalan = Cash_galan - BILLgalan;
                JOptionPane.showMessageDialog(null, "TOTAL BILL :  " + BILLgalan
                        + "\nChange :  " + chGalan);
            }
        } else {
            valgalan.setText("Invalid");
            JOptionPane.showMessageDialog(null, "Invalid cash !");
        }
    }//GEN-LAST:event_processGalanActionPerformed

    public static void main(String Galan[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new galanOOP_resemble().setVisible(true);
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
    private javax.swing.JTextField cashgalan;
    private javax.swing.JTextField idgalan;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel16galan;
    private javax.swing.JLabel jLabel18galan;
    private javax.swing.JLabel jLabel1galan;
    private javax.swing.JLabel jLabel2galan;
    private javax.swing.JLabel jLabel4galan;
    private javax.swing.JLabel jLabel5galan;
    private javax.swing.JLabel jLabel7galan;
    private javax.swing.JLabel jLabel8galan;
    private javax.swing.JButton processGalan;
    private javax.swing.JLabel taxgalan;
    private javax.swing.JLabel valgalan;
    // End of variables declaration//GEN-END:variables
}
